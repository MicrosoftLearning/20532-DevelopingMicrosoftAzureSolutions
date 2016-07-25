using System.Web;
using System.Web.Optimization;

namespace Contoso.Events.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.moreLink.js"));

            bundles.Add(new ScriptBundle("~/scripts/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/styles/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}