using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SonarQubeSpike.Startup))]
namespace SonarQubeSpike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
