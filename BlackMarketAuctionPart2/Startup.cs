using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlackMarketAuctionPart2.Startup))]
namespace BlackMarketAuctionPart2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
