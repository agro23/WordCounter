using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using WordCounter.Models;
using WordCounter;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      RepeatCounter Count = new RepeatCounter("Apples", "I hear apples are pretty nice.");
      // Console.WriteLine("Your word " + Count.GetKeyword() + " appeared " + RepeatCounter.Counter(Count.GetKeyword(), RepeatCounter.ValidateSentence(Count.GetSentence())) + " time(s).");
      // Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
      string model="";
      // model.Add("msg", ""); // create message to pass at load time
      return View("Index", model);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      // Dictionary<string, object> model = new Dictionary<string, object>(); // create dictionary to pass as Model
      string x =  Request.Form["Word"];
      string y =  Request.Form["Sentence"];
      // RepeatCounter Count = new RepeatCounter(x, y);
      string model = "Your word " + x + " appeared in the sentence " + y + " " + RepeatCounter.Counter(x, RepeatCounter.ValidateSentence(y)) + " time(s).";
      // string model = "";
      // model.Add("msg", ""); // create blank message to pass at load time
      return View("Index", model);
    }

  }
}
