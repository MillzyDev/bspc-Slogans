using Zenject;

namespace Slogans.Installers
{
    public class SAppInstaller : Installer
    {
        private readonly Config _config;
        private readonly Plugin _plugin;
        
        public SAppInstaller(Config config, Plugin plugin)
        {
            _config = config;
            _plugin = plugin;
        }
        
        public override void InstallBindings()
        {
            Container.BindInstance(_config).AsSingle();
            Container.BindInstance(_plugin).AsSingle();
        }
    }
}