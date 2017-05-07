using System.Web;
using System.Web.Optimization;

namespace BigStore
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // jQuery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Plugins/bower_components/jquery/dist/jquery.min.js"
                        ));

            // Bootstrap Core JavaScript
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Frameworks/bootstrap/dist/js/tether.min.js",
                        "~/Frameworks/bootstrap/dist/js/bootstrap.min.js",
                        "~/Plugins/bower_components/bootstrap-extension/js/bootstrap-extension.min.js"
                        ));

            // Menu Plugin JavaScript
            bundles.Add(new ScriptBundle("~/bundles/menu").Include(
                        "~/Plugins/bower_components/sidebar-nav/dist/sidebar-nav.min.js"
                        ));

            // slimscroll JavaScript
            bundles.Add(new ScriptBundle("~/bundles/slimscroll").Include(
                        "~/Scripts/jquery.slimscroll.js"
                        ));

            // Wave Effects
            bundles.Add(new ScriptBundle("~/bundles/wave-effects").Include(
                        "~/Scripts/waves.js"
                        ));

            // Counter js
            bundles.Add(new ScriptBundle("~/bundles/counter").Include(
                        "~/Plugins/bower_components/waypoints/lib/jquery.waypoints.js",
                        "~/Plugins/bower_components/counterup/jquery.counterup.min.js"
                        ));

            // Morris JavaScript
            bundles.Add(new ScriptBundle("~/bundles/morris").Include(
                        "~/Plugins/bower_components/raphael/raphael-min.js",
                        "~/Plugins/bower_components/morrisjs/morris.js"
                        ));

            // Custom Theme JavaScript
            bundles.Add(new ScriptBundle("~/bundles/custom-theme").Include(
                        "~/Scripts/custom.min.js"
                        ));

            // Sparkline chart JavaScript
            bundles.Add(new ScriptBundle("~/bundles/sparkline-chart").Include(
                        "~/Plugins/bower_components/jquery-sparkline/jquery.sparkline.min.js",
                        "~/bower_components/jquery-sparkline/jquery.charts-sparkline.js",
                        "~/Scripts/dashboard1.js"
                        ));

            // Style Switcher
            bundles.Add(new ScriptBundle("~/bundles/style-switcher").Include(
                        "~/Plugins/bower_components/styleswitcher/jQuery.style.switcher.js"
                        ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Frameworks/dist/css/bootstrap.min.css",
                      "~/Plugins/bower_components/bootstrap-extension/css/bootstrap-extension.css",
                      "~/Plugins/bower_components/sidebar-nav/dist/sidebar-nav.min.css",
                      "~/Plugins/bower_components/toast-master/css/jquery.toast.css",
                      "~/Plugins/bower_components/morrisjs/morris.css",
                      "~/Content/animate.css",
                      "~/Content/style.css",
                      "~/Content/colors/default.css"));
        }
    }
}
