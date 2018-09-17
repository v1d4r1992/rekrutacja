using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StackTags
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


			routes.MapRoute(
				name: "Tags",
				url: "",
				defaults: new { controller = "Home", action = "Index" }
			);

			routes.MapRoute(
				name: "TagsTable",
				url: "TagsTable",
				defaults: new { controller = "Home", action = "TagTable" }
			);
		}
	}
}
