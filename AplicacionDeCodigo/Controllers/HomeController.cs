using AplicacionDeCodigo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

namespace AplicacionDeCodigo.Controllers
{
    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        private readonly IConfiguration _configuration;
        private readonly Context _graphicsContext;
        public HomeController(Context context, IConfiguration configuration)
        {
            _graphicsContext = context;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*----------------------*/
        /*public IActionResult RedireccionarAChart()
        {
            return RedirectToAction("chart");
        }*/

        public IActionResult chart()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }
        
        public IActionResult plotly()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }
        public IActionResult RedireccionarAamCharts()
        {
            return RedirectToAction("amCharts");
        }

        public IActionResult amCharts()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }
        public IActionResult RedireccionarAanychart()
        {
            return RedirectToAction("anychart");
        }

        public IActionResult anychart()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;
            return View();
        }
        public IActionResult RedireccionarAChartist()
        {
            return RedirectToAction("chartist");
        }

        public IActionResult chartist()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;
            return View();
        }
        public IActionResult RedireccionarAHighcharts()
        {
            return RedirectToAction("highcharts");
        }

        public IActionResult highcharts()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }
        public IActionResult RedireccionarAecharts()
        {
            return RedirectToAction("ECharts");
        }

        public IActionResult ECharts()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }
        public IActionResult RedireccionarAEChart()
        {
            return RedirectToAction("EChart");
        }

        public IActionResult EChart()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }

        public IActionResult RedireccionarAapexcharts()
        {
            return RedirectToAction("apexcharts");
        }

        public IActionResult apexcharts()
        {
            List<DateTime> fechas = new List<DateTime>();
            List<decimal> montos = new List<decimal>();

            List<Ventas> datosVentas = _graphicsContext.ventas.ToList();
            foreach (var venta in datosVentas)
            {
                fechas.Add(venta.fecha);
                montos.Add(venta.monto);
            }

            ViewBag.Fechas = fechas;
            ViewBag.Montos = montos;

            return View();
        }
    }
}
