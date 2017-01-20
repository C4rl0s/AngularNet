using System.Web;
using System.Web.Optimization;

namespace WebApplicationAngularCsharp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Vendor/jquery").Include(
                        "~/Scripts/Vendor/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/Vendor/modernizr").Include(
                        "~/Scripts/Vendor/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/Vendor/bootstrap").Include(
                      "~/Scripts/Vendor/bootstrap.js",
                      "~/Scripts/Vendor/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/Vendor/angular").Include(
                      "~/Scripts/Vendor/angular.min.js",
                      "~/Scripts/Vendor/angular-resource.min.js",
                      "~/Scripts/Vendor/angular-route.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/app/app.js",
                "~/Scripts/app/clubCLientService.js",
                "~/Scripts/app/simple/simpleClubService.js",
                "~/Scripts/app/simple/simpleController.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
