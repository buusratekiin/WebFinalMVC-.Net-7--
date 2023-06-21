using Microsoft.AspNetCore.Mvc;
using Service.Classes;
using Service.ViewModels;

namespace proje.Controllers
{
    public class FilmController : Base
    {
        private FilmService filmService;
        public FilmController()
        {
            filmService = new FilmService();
        }
        public IActionResult Index()
        {

            FilmService filmService = new FilmService();
            var list = filmService.GetFilms();
            return View(list);

        }
        
        
        public IActionResult Create()
        {
            var vm = filmService.getFilmCE_VM();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(FilmVM vm)
        {
            filmService.AddFilm(vm);
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
           var result=filmService.DeleteFilm(id);
            if (result == false)
                ViewData["message"] = "no";
            else
                ViewData["message"] = "yes";
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id )
        {
            var vm = filmService.getFilmEdit_VM(id);
            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(FilmVM vm)
        {
            filmService.EditFilm(vm);
            return RedirectToAction("Index");
        }

    }
}
