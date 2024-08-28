using Api_Login.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Api_Login.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Policy = "EmailPolicy")]
        public IActionResult Privacy()
        {

            var contatos = new List<Contatos>
        {
            new Contatos { Id = 1, Nome = "Luciano Soares", Email = "lucianoSoares@teste.com" },
            new Contatos { Id = 2, Nome = "Luiz Silva", Email = "luiz@teste.com" },
            new Contatos { Id = 3, Nome = "Maria Oliveira", Email = "maria.oliveira@teste.com" },
            new Contatos { Id = 4, Nome = "João Santos", Email = "joao.santos@teste.com" },
            new Contatos { Id = 5, Nome = "Ana Souza", Email = "ana.souza@teste.com" },
            new Contatos { Id = 6, Nome = "Carlos Pereira", Email = "carlos.pereira@teste.com" },
            new Contatos { Id = 7, Nome = "Fernanda Lima", Email = "fernanda.lima@teste.com" },
            new Contatos { Id = 8, Nome = "Paulo Andrade", Email = "paulo.andrade@teste.com" },
            new Contatos { Id = 9, Nome = "Juliana Costa", Email = "juliana.costa@teste.com" },
            new Contatos { Id = 10, Nome = "Rafael Carvalho", Email = "rafael.carvalho@teste.com" }
        };

            return View(contatos);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
