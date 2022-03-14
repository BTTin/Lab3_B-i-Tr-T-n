using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_Bùi_Trí_Tín.Startup))]
namespace Lab3_Bùi_Trí_Tín
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
