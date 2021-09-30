using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_EntityFrameworkDbContext.Startup))]
namespace MVC_EntityFrameworkDbContext
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
