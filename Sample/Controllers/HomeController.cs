using KaveNegarApi.Contracts;
using Microsoft.AspNetCore.Mvc;
using Sample.Models;
using System.Diagnostics;

namespace Sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ISmsSenderService smsSenderService)
        {
            var res= smsSenderService.KavenegarApi.VerifyLookup("09902500000", "1234", "SendCode", Kavenegar.Models.Enums.VerifyLookupType.Sms);
            _logger = logger;
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
    }
}
