using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProReRe.Startup))]
namespace FinalProReRe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
