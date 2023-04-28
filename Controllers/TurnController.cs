using Microsoft.AspNetCore.Mvc;
using smmf8quee.Models;
using smmf8quee.Services.Interfaces;

namespace smmf8quee.Controllers
{
    public class TurnController : Controller
    {
        ITurnService _turnService;

        public TurnController(ITurnService turnService) {
            _turnService = turnService; 
        }

        public ActionResult Index()
        {
            var Model = _turnService.GetTurns();
            return View(Model);
        }

        public ActionResult Details(int id)
        {
            var model = _turnService.GetTurn(id);
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Turns Turn)
        {
            _turnService.AddTurn(Turn);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var model = _turnService.GetTurn(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Turns Turn)
        {
            _turnService.EditTurn(Turn);
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var model = _turnService.GetTurn(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Turns turn)
        {
            _turnService.DeleteTurn(turn);
            return RedirectToAction(nameof(Index));
        }
    }
}
