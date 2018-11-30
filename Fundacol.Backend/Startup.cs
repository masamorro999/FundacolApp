using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fundacol.Backend.Startup))]
namespace Fundacol.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
