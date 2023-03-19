using System;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using Slogans.UI.FlowCoordinators;
using Zenject;

namespace Slogans.Managers
{
    public class MenuButtonManager : IInitializable, IDisposable
    {
        private readonly MenuButton _menuButton;
        private readonly MainFlowCoordinator _mainFlowCoordinator;
        private readonly SlogansFlowCoordinator _slogansFlowCoordinator;

        public MenuButtonManager(MainFlowCoordinator mainFlowCoordinator, SlogansFlowCoordinator slogansFlowCoordinator)
        {
            _menuButton = new MenuButton(nameof(Slogans), ShowFlowCoordinator);
            _mainFlowCoordinator = mainFlowCoordinator;
            _slogansFlowCoordinator = slogansFlowCoordinator;
        }

        public void Initialize()
        {
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void Dispose()
        {
            if (BSMLParser.IsSingletonAvailable && MenuButtons.IsSingletonAvailable)
            {
                MenuButtons.instance.UnregisterButton(_menuButton);
            }
        }

        private void ShowFlowCoordinator()
        {
            _mainFlowCoordinator.PresentFlowCoordinator(_slogansFlowCoordinator, animationDirection: HMUI.ViewController.AnimationDirection.Vertical);
        }
    }
}