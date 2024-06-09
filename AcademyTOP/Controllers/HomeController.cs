using Microsoft.AspNetCore.Mvc;

namespace AcademyTOP.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public void GetData(string name, 
			                string numberPhone, 
							string group, 
							string block, 
							string theme, 
							string dataLose, 
							string freeTime, 
							JsonContent file)
		{
			string FormControlFile = name.ToString();
			


		}
	}
}
