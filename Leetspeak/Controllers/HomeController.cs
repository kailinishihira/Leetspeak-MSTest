using Microsoft.AspNetCore.Mvc;
using Leetspeak.Models;
using System.Collections.Generic;
using System;

namespace Leetspeak.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/leet/translate")]
    public ActionResult Translate()
    {
      LeetspeakTranslator.ClearAll();
      LeetspeakTranslator leet = new LeetspeakTranslator (Request.Form["input-word"]);
      List<string> translate = new List<string>();
      translate = leet.ChangeLetter();
      return View(translate);
    }

    [HttpPost("/")]
    public ActionResult Clear()
    {
      return View();
    }
  }
}
