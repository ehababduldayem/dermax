using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Englishna.Startup))]
namespace Englishna
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
