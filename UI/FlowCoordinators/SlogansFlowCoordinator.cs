using HMUI;
using Zenject;

namespace Slogans.UI.FlowCoordinators
{
    public class SlogansFlowCoordinator : FlowCoordinator
    {
        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            if (!firstActivation) return;
            
            SetTitle(nameof(Slogans));
            showBackButton = true;
        }
        
        [Inject]
        public void Inject()
        {
            
        }
    }
}