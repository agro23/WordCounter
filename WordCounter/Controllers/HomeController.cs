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
      string model="";
      return View("Index", model);
    }

    [HttpPost("/")]
    public ActionResult Result()
    {
      string keyword =  Request.Form["Word"];
      string sentence =  Request.Form["Sentence"];
      string model ="";
      if ((! string.IsNullOrEmpty(keyword) ) && (! string.IsNullOrEmpty(sentence)) )
      {
        model = "Your word '" + keyword + "' appeared in the sentence '" + sentence + "' " + RepeatCounter.Counter(keyword, RepeatCounter.ValidateSentence(sentence)) + " time(s).";
      }
      else
      {
        model = "Please enter a valid keyword and sentence.";
      }
      return View("Index", model);
    }

  }
}
