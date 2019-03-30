using System.Web;
using System.Web.Optimization;

namespace HotelProject
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
            bundles.Add(new StyleBundle("~/Content/mainCSS").Include(
                 "~/Content/styles/bootstrap-4.1.2/bootstrap.min.css",
                 "~/Content/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                 "~/Content/plugins/OwlCarousel2-2.3.4/owl.carousel.css",
                 "~/Content/plugins/OwlCarousel2-2.3.4/owl.theme.default.css",
                 "~/Content/plugins/OwlCarousel2-2.3.4/animate.css",
                 "~/Content/plugins/jquery-datepicker/jquery-ui.css",
                 "~/Content/plugins/colorbox/colorbox.css",
                 "~/Content/styles/main_styles.css",
                 "~/Content/styles/responsive.css",
                 "~/Content/styles/main.css"
                ));
            bundles.Add(new ScriptBundle("~/Content/mainJS").Include(
                 "~/Content/js/jquery-3.3.1.min.js",
                 "~/Content/styles/bootstrap-4.1.2/popper.js",
                 "~/Content/styles/bootstrap-4.1.2/bootstrap.min.js",
                 "~/Content/plugins/greensock/TweenMax.min.js",
                 "~/Content/plugins/greensock/TimelineMax.min.js",
                 "~/Content/plugins/scroolmagic/ScroolMagic.min.js",
                 "~/Content/plugins/greensock/animation.gsap.min.js",
                 "~/Content/plugins/greensock/ScroolToPlugin.min.js",
                 "~/Content/plugins/OwlCarousel2-2.3.4/owl.carousel.js",
                 "~/Content/plugins/easing/easing.js",
                 "~/Content/plugins/progressbar/progressbar.min.js",
                 "~/Content/plugins/parallax-js-master/parallax.min.js",
                 "~/Content/plugins/jquery-datepicker/jquery-ui.js",
                 "~/Content/plugins/colorbox/jquery.colorbox-min.js",
                 "~/Content/plugins/colorbox/jquery.colorbox-min.js",
                 "~/Content/js/custom.js"
                ));
            bundles.Add(new StyleBundle("~/Content/AdminCss").Include(
                 "~/Content/Admin/plugins/bootstrap/css/bootstrap.min.css",
                 "~/Content/Admin/plugins/node-waves/waves.css",
                 "~/Content/Admin/plugins/animate-css/animate.css",
                 "~/Content/Admin/plugins/morrisjs/morris.css",
                 "~/Content/Admin/css/style.css",
                 "~/Content/Admin/css/themes/all-themes.css"
                ));
            bundles.Add(new ScriptBundle("~/Content/AdminJs").Include(
                 "~/Content/Admin/plugins/jquery/jquery.min.js",
                 "~/Content/Admin/plugins/bootstrap/js/bootstrap.js",
                 "~/Content/Admin/plugins/bootstrap-select/js/bootstrap-select.js",
                 "~/Content/Admin/plugins/jquery-slimscroll/jquery.slimscroll.js",
                 "~/Content/Admin/plugins/node-waves/waves.js",
                 "~/Content/Admin/plugins/jquery-countto/jquery.countTo.js",
                 "~/Content/Admin/plugins/raphael/raphael.min.js",
                 "~/Content/Admin/plugins/morrisjs/morris.js",
                 "~/Content/Admin/plugins/chartjs/Chart.bundle.js",
                 "~/Content/Admin/plugins/flot-charts/jquery.flot.js",
                 "~/Content/Admin/plugins/flot-charts/jquery.flot.resize.js",
                 "~/Content/Admin/plugins/flot-charts/jquery.flot.pie.js",
                 "~/Content/Admin/plugins/flot-charts/jquery.flot.categories.js",
                 "~/Content/Admin/plugins/flot-charts/jquery.flot.time.js",
                 "~/Content/Admin/plugins/jquery-sparkline/jquery.sparkline.js",
                 "~/Content/Admin/js/admin.js",
                 "~/Content/Admin/js/pages/index.js",
                 "~/Content/Admin/js/demo.js"
                ));

        }
    }
}
