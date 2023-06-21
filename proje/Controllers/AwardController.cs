using Microsoft.AspNetCore.Mvc;
using Service.Classes;
using Service.ViewModels;

namespace proje.Controllers
{
    public class AwardController : Controller
    {
        private AwardService awardService;
        public AwardController()
        {
            awardService = new AwardService();
        }
        public IActionResult Index(int filmid)
        { 
            var vm = awardService.GetAwardsVM(filmid);
            return View(vm);
        }


        public IActionResult Create(int filmid)
        {
            var vm = awardService.getAwardsCE_VM(filmid);
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(AwardsCE_VM vm)
        {
            awardService.AddAdwar(vm);
            return RedirectToAction("Index","Film");
        }
    }
}
