using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Curso.Startup))]
namespace Curso
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
