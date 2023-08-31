using AtividadeCRUDCsharp.Data;
using AtividadeCRUDCsharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AtividadeCRUDCsharp.Controllers
{
	public class MunicipeController : Controller
	{
		readonly private ApplicationDbContext _db;

		public MunicipeController(ApplicationDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			IEnumerable<MunicipeModel> municipe = _db.Municipe;
			return View(municipe);
		}

		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar (MunicipeModel municipe) 
		{ 
			if (ModelState.IsValid)
			{
				_db.Municipe.Add(municipe);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}

			return View();
		}

		[HttpGet]
		public IActionResult Editar (int? id)
		{
			if (id == null || id == 0) 
			{ 
				return NotFound();
			}

			MunicipeModel municipe = _db.Municipe.FirstOrDefault(x => x.Id == id);

			if (municipe == null)
			{
				return NotFound();
			}

			return View(municipe);
		}

		[HttpPost]
		public IActionResult Editar (MunicipeModel municipe)
		{
			if (ModelState.IsValid)
			{
				_db.Municipe.Update(municipe);
				_db.SaveChanges();

				return RedirectToAction("Index");
			}
			return View(municipe);
		}

		[HttpGet]
		public IActionResult Excluir(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}

			MunicipeModel municipe = _db.Municipe.FirstOrDefault(x => x.Id == id);

			if (municipe == null)
			{
				return NotFound();
			}

			return View(municipe);
		}

		[HttpPost]
		public IActionResult Excluir(MunicipeModel municipe)
		{
			if (municipe == null)
			{
				return NotFound();
			}

			_db.Municipe.Remove(municipe);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
