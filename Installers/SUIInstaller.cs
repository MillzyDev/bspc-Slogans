using Slogans.Managers;
using Slogans.UI.FlowCoordinators;
using Slogans.UI.ViewControllers;
using Zenject;

namespace Slogans.Installers
{
    public class SUIInstaller : Installer
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<MenuButtonManager>();

            Container.Bind<EditorViewController>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<SelectionViewController>().FromNewComponentAsViewController().AsSingle();
            Container.Bind<PreviewViewController>().FromNewComponentAsViewController().AsSingle();

            Container.Bind<SlogansFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();
        }
    }
}