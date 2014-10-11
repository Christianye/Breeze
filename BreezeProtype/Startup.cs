using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BreezeProtype.Startup))]
namespace BreezeProtype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
