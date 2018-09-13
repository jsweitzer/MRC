using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MRC.Startup))]
namespace MRC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
