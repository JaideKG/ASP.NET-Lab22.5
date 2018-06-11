using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET_Lab22._5.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			List<Register> registerList = new List<Register>();
			registerList.Add(new Register("Sally", "Blue", "Basketball"));
			registerList.Add(new Register("Patty", "Yellow", "Volleyball"));
			registerList.Add(new Register("Tally", "Pink", "Soccer"));

			//ViewBag.RegisterList = registerList;
			Session["RegisterList"] = registerList;


			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "In just a matter of seconds, The One Stop Sports Shop App allows our clients the convenience to register for custom made sports gear." +
							 "With just a click of a button select your color, select your sport, and your package will be cruising on it's way!";


			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
		public ActionResult Registration()
		{
			return View();
		}
		public ActionResult Create(Register r)
		{
			if (ModelState.IsValid)
			{
				//ViewBag.Register = r;
				Session["Register"] = r;
				return View();
			}
			else
			{
				return View("Registration");
			}
		}
		public ActionResult Register(string UserName = "",
			string Color = "", string Sport = "")
		{
			Dictionary<string, string> Register = new Dictionary<string, string>();

			Register.Add("UserName", UserName);
			Register.Add("Color", Color);
			Register.Add("Sport", Sport);
			Session["Register"] = Register;
			
			//ViewBag.UserName = UserName;
			//ViewBag.Color = Color;
			//ViewBag.Sport = Sport;
			return View();
		}
	}
}
	