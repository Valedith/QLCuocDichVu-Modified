using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuanLyDienThoaiEntity.Startup))]
namespace QuanLyDienThoaiEntity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
