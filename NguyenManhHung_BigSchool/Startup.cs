using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenManhHung_BigSchool.Startup))]
namespace NguyenManhHung_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
