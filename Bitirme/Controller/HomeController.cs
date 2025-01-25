using Microsoft.AspNetCore.Mvc;

namespace Bitirme.Controller;

public class HomeController : Microsoft.AspNetCore.Mvc.Controller
{
    // GET
    public IActionResult Index()
    {
        var chartData = new List<object>
        {
            new { Ay = "Ocak", Satis = 35 },
            new { Ay = "Şubat", Satis = 28 },
            new { Ay = "Mart", Satis = 34 },
            new { Ay = "Nisan", Satis = 32 }
        };

        ViewBag.ChartData = chartData;
        return View();
    }
}