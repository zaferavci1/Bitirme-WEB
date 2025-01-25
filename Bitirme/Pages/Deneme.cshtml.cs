using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bitirme.Pages;

public class Deneme : PageModel
{
    public void OnGet()
    {
        
    }
    
    public class PieChartData
    {
        public string xValue;
        public double yValue;
        public string text;
        public string fill;
    }
}