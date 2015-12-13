using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MultiDbContextForeignKeySample.Startup))]
namespace MultiDbContextForeignKeySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
