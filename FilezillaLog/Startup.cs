using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FilezillaLog.Startup))]
namespace FilezillaLog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
