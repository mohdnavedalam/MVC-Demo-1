using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Demo_1.Startup))]
namespace MVC_Demo_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
