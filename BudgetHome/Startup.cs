using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BudgetHome.Startup))]
namespace BudgetHome
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
