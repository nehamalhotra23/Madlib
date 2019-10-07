using Microsoft.AspNetCore.Mvc;
using Madlib.Models;


namespace Madlib.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Madlib() { 
      return View();
    }

    [Route("/result")]
    public ActionResult Result(string noun, string verb, string adjective, string adverb, string exclamation) { 
        MadlibVariable newMadlib = new MadlibVariable(noun, verb,  adverb, adjective, exclamation);
        return View(newMadlib);
    }
     [Route("/puppy-story")]
    public ActionResult PuppyStory(string verb, string adjective) { 
        MadlibVariable newMadlib = new MadlibVariable(verb, adjective);
        return View(newMadlib);
    }

    [Route("/puppy-story-form")]
    public ActionResult PuppyStoryForm()
    {
        return View();
    }
  }
}