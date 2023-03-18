using IPA;
using IPA.Config.Stores;
using SiraUtil.Attributes;
using SiraUtil.Zenject;
using Slogans.Installers;
using Conf = IPA.Config.Config;
using IPALogger = IPA.Logging.Logger;

namespace Slogans
{
    [Plugin(RuntimeOptions.DynamicInit), Slog, NoEnableDisable]
    public class Plugin
    {
        [Init]
        public Plugin(Conf conf, IPALogger logger, Zenjector zenjector)
        {
            var config = conf.Generated<Config>();
            
            zenjector.UseHttpService();
            zenjector.UseLogger(logger);
            
            zenjector.Install<SAppInstaller>(Location.App, config, this);
        }
    }
}