using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
      model.Add("msg", "Enter a Scrabble Word to Get the Word's Point Value."); // create message to pass at load time
      return View("Index", model);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
      // string x =  Request.Form["Word"];
      model.Add("msg", ""); // create blank message to pass at load time
      return View("Index", model);
    }

  }
}
