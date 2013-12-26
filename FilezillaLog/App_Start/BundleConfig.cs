using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Optimization;

namespace FilezillaLog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                        "~/Scripts/angular/angular.js",
                        "~/Scripts/angular/angular-resource.js",
                        "~/Scripts/angular/angular-animate.js",
                        "~/Scripts/angular/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                        "~/Scripts/app/filezillaLogApp.js"));

            bundles.Add(new ScriptBundle("~/bundles/controllers").Include(
                        BuildRelativePaths("~/Scripts/app/controllers/")));

            bundles.Add(new ScriptBundle("~/bundles/services").Include(
                        BuildRelativePaths("~/Scripts/app/services/")));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }

        private static string[] BuildRelativePaths(string directory)
        {
            string fileDirectory = directory.Replace("~/", "").Replace("/", "\\");
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + fileDirectory);
            List<string> results = new List<string>();
            foreach (string file in files)
            {
                results.Add(directory + Path.GetFileName(file));
            }
            return results.ToArray();
        }
    }
}
