using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataStructure.UI.Startup))]
namespace DataStructure.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
