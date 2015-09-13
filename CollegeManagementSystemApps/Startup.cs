using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeManagementSystemApps.Startup))]
namespace CollegeManagementSystemApps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
