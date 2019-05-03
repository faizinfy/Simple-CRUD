using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Simple_CRUD.Startup))]
namespace Simple_CRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
