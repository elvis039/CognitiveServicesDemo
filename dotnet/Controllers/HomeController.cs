using System;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using WebApplication.Models;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        // =========================================================        
        // We will do all of our work in these functions
        // =========================================================
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string link)
        {
            var submittedPhoto = link;

            // Make API Call and get back top emotion
            // var results = await MakeRequest(submittedPhoto);

            // Parse the results and get the top emotion
            // var topEmotion = ParseResults(results);

            // Decide which picture and description to display
            // var suggestion = MakeSuggestion(topEmotion);

            // Pass the suggestion to the Results page to be displayed
            // return RedirectToAction("Results", suggestion);

            // Remove this once you paste in the proper code snippets
            return View();
        }

        [HttpGet]
        public IActionResult Results(Result model)
        {
            if (model == null)
            {
                return RedirectToAction("Index", null);
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Results()
        {
            return RedirectToAction("Index");
        }

        // =========================================================
        // Helper functions, paste code snippets here
        // =========================================================
        

    }
}
