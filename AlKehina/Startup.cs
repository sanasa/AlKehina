using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlKehina.Startup))]
namespace AlKehina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
