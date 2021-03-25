using System.Web;
using System.Web.Optimization;

namespace WebApplication1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/js/vendor/modernizr-3.5.0.min.js",
                      "~/js/vendor/jquery-1.12.4.min.js",
                      "~/js/popper.min.js",
                      "~/js/bootstrap.min.js",
                      "~/js/owl.carousel.min.js",
                      "~/js/isotope.pkgd.min.js",
                      "~/js/ajax-form.js",
                      "~/js/waypoints.min.js",
                      "~/js/jquery.counterup.min.js",
                      "~/js/imagesloaded.pkgd.min.js",
                      "~/js/scrollIt.js",
                      "~/js/jquery.scrollUp.min.js",
                      "~/js/wow.min.js",
                      "~/js/nice-select.min.js",
                      "~/js/jquery.slicknav.min.js",
                      "~/js/jquery.magnific-popup.min.js",
                      "~/js/plugins.js",
                      "~/js/gijgo.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/contactJs").Include(
                      "~/js/contact.js",
                      "~/js/jquery.ajaxchimp.min.js",
                      "~/js/jquery.form.js",
                      "~/js/jquery.validate.min.js",
                      "~/js/mail-script.js",
                      "~/js/main.js"));

            bundles.Add(new StyleBundle("~/css/css").Include(
                      "~/css/bootstrap.min.css",
                      "~/css/owl.carousel.min.css",
                      "~/css/magnific-popup.css",
                      "~/css/font-awesome.min.css",
                      "~/css/themify-icons.css",
                      "~/css/nice-select.css",
                      "~/css/flaticon.css",
                      "~/css/gijgo.css",
                      "~/css/animate.css",
                      "~/css/slicknav.css",
                      "~/css/style.css"));
        }
    }
}
