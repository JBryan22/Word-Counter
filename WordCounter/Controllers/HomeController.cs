using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/results")]
        public ActionResult Results()
        {
            string userInput = Request.Form["user-input"];
            string find = Request.Form["search-for"];
            int result;

            RepeatCounter newCount = new RepeatCounter();
            result = newCount.CountRepeats(userInput, find);

            return View(result);
        }
    }
}