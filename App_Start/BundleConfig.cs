using System.Web;
using System.Web.Optimization;

namespace WebTemplate
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/d3").Include(
						"~/Scripts/ThirdParty/d3/d3.js"));

			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/ThirdParty/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/knockout").Include(
						"~/Scripts/ThirdParty/knockout-{version}.js"));			

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/site.css"));
		}
	}
}