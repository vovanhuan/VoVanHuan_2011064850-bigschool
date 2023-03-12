using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VoVanHuan_2011064850_.Startup))]
namespace VoVanHuan_2011064850_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
