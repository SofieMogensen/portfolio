using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SofiePorteFolio.Startup))]
namespace SofiePorteFolio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
