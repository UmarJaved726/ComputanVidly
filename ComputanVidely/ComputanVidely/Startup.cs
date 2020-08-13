using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComputanVidely.Startup))]
namespace ComputanVidely
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
