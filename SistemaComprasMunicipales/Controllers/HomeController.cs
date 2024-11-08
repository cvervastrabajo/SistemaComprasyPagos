using Microsoft.AspNetCore.Mvc;
using SistemaComprasMunicipales.Models;
using System.Diagnostics;
using CapaDeDatos.Repositorio;
using CapaDeDatos.Entidades;
namespace SistemaComprasMunicipales.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepositorio _repositorio;

        public HomeController(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task <IActionResult> MostrarUsuarios()
        {
            List<Usuarios> lcd = await _repositorio.ObtenerUsuarios();

            return View(lcd);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
