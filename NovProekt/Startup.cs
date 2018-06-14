using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NovProekt.Startup))]
namespace NovProekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
