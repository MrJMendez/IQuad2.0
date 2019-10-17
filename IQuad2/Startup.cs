using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IQuad2.Startup))]
namespace IQuad2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
