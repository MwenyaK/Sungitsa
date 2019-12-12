using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sungitsa.View.Startup))]
namespace Sungitsa.View
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
