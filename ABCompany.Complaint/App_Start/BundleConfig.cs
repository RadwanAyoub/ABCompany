using System.Web;
using System.Web.Optimization;

namespace ABCompany.Complaint
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //All JS
            //All Plugins
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/js/jquery.min.js",
                        "~/Scripts/js/popper.min.js",
                        "~/Scripts/js/jquery.magnific-popup.min.js",
                        "~/Scripts/js/smoothscroll.js",
                        "~/Scripts/js/form-validator.min.js",
                        "~/Scripts/js/contact-form-script.js",
                        "~/Scripts/js/isotope.min.js",
                        "~/Scripts/js/images-loded.min.js",
                        "~/Scripts/js/custom.js",
                        "~/Scripts/js/slider-index.js"));

            //Bootstrap JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/js/bootstrap.min.js"));

            //Site CSS
            //Bootstrap CSS
            //Responsive CSS
            //Custom CSS
            //Pogo Slider CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/pogo-slider.min.css",
                "~/Content/css/style.css",
                "~/Content/css/responsive.css",
                "~/Content/css/custom.css"));
        }
    }
}
