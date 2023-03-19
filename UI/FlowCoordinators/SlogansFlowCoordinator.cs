using BeatSaberMarkupLanguage;
using HMUI;
using Slogans.UI.ViewControllers;
using Zenject;

namespace Slogans.UI.FlowCoordinators
{
    public class SlogansFlowCoordinator : FlowCoordinator
    {
        private EditorViewController _editorViewController;
        private SelectionViewController _selectionViewController;
        private PreviewViewController _previewViewController;
        private MainFlowCoordinator _mainFlowCoordinator;

        [Inject]
        public void Inject(EditorViewController editorViewController, SelectionViewController selectionViewController, 
            PreviewViewController previewViewController, MainFlowCoordinator mainFlowCoordinator)
        {
            _editorViewController = editorViewController;
            _selectionViewController = selectionViewController;
            _previewViewController = previewViewController;
            _mainFlowCoordinator = mainFlowCoordinator;
        }
        
        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation) return;
            
            SetTitle(nameof(Slogans));
            showBackButton = true;
            
            ProvideInitialViewControllers(_editorViewController, _selectionViewController, _previewViewController);
        }

        protected override void BackButtonWasPressed(ViewController _)
        {
            _mainFlowCoordinator.DismissFlowCoordinator(this);
        }
    }
}