using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(E_Banking_Client.Startup))]
namespace E_Banking_Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
