using CountryGuide.Models;
using CountryGuide.Services;
using Microsoft.AspNetCore.Mvc;

namespace CountryGuide.Controllers
{
    public class PaisController : Controller
    {
        private readonly PaisService _paisService;
        public PaisController(PaisService paisService)
        {
            _paisService = paisService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string nome)
        {
            Pais? pais = await _paisService.ObterPaisAsync(nome);
            return View(pais);
        }

    }
}
