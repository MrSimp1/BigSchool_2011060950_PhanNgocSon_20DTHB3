using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool_2011060950_PhanNgocSon_20DTHB3.Startup))]
namespace BigSchool_2011060950_PhanNgocSon_20DTHB3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
