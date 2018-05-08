using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PaymentWebservice.Startup))]
namespace PaymentWebservice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
