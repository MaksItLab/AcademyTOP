using AcademyTOP.DataAccessLayer;
using AcademyTOP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AcademyTOP.Controllers
{
	public class HomeController : Controller
	{
		private readonly IWebHostEnvironment _hostingEnvironment;
		private readonly ApplicationDbContext _context;

		public HomeController(IWebHostEnvironment hostingEnvironment, ApplicationDbContext context)
		{
			_hostingEnvironment = hostingEnvironment;
			_context = context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Send(Request req)
		{	
			string[] NameSurnamePatronymic = req.Name.Split(' ');

			try
			{
                req.Surname = NameSurnamePatronymic[0];
                req.Name = NameSurnamePatronymic[1];
                req.Patronymic = NameSurnamePatronymic[2];
            }
			catch (Exception ex)
			{

			}
			

			if (req.FormFile != null && req.FormFile.Length > 0)
			{

				var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", req.FormFile.FileName);

				using (FileStream stream = new FileStream(filePath, FileMode.Create))
				{
					await req.FormFile.CopyToAsync(stream);
				};
			}

			//Перевод объекта из AcademyTOP.Models.Request в AcademyTOP.DataAccessLayer.Models.Request
			var request = new DataAccessLayer.Models.Request
			{
				Name = req.Name,
				Block = req.Block,
				DataMiss = req.DataMiss,
				FreeTime = req.FreeTime,
				NameFile = req.FormFile?.FileName,
				NumberGroup = req.NumberGroup,
				NumberPhone = req.NumberPhone,
				Patronymic = req.Patronymic,
				Surname = req.Surname,
			};
			//Отслеживание нового объекта
            await _context.Requests.AddAsync(request);

			//Сохранение данных
			await _context.SaveChangesAsync();

			return View();
		}

	}
		

}
