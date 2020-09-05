using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonsterClient.Models;
using Monsters.View.Models;
using Newtonsoft.Json;

namespace MonsterClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var accessToken = await HttpContext.GetTokenAsync("access_token");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            var content = await client.GetStringAsync("https://localhost:44392/doors/freedoors");

            //var createScare = new CreateScareRequest()
            //{
            //    DoorId = "door1"
            //};

            //var json = JsonConvert.SerializeObject(createScare);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            //var url = "https://localhost:44392/doors/scare";
            //var response = await client.PostAsync(url, data);

            

            return View();
        }

        [Authorize]
        public async Task<IActionResult> MonsterCard()
        {
            //var list = User.Claims.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
