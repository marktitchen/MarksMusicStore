using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarksMusicStore.Startup))]
namespace MarksMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
