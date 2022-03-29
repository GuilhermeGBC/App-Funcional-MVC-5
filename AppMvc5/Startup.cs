using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppMvc5.Startup))]
namespace AppMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
