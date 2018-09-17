using StackTags.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StackTags.Controllers
{
	public class UserModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
	}

	public class HomeController : Controller
	{
		[HttpPost]
		public ActionResult TagTable(string[] data)
		{
			TagModel tags = new TagModel();

			if (data != null)
			{
				tags.GetTagsFromArray(data);
			}
			return View(tags);
		}



		// GET: Tags
		public ActionResult Index()
		{
			TagModel tags = new TagModel();

			return View(tags);
		}
	}
}