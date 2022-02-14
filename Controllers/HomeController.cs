using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller 
  {
    [Route("/Form")]
    public ActionResult Form() { return View(); }

    [Route("/MadStory")]
    public ActionResult MadStory(string adjective1, string adjective2, string noun1, string pluralnoun1, string game, string pluralnoun2, string verbing1, string verbing2, string pluralnoun3)
    {
      MadVariable myMadVariable = new MadVariable();
      myMadVariable.Adjective1 = adjective1;
      myMadVariable.Noun1 = noun1;
      myMadVariable.Adjective2 = adjective2;
      myMadVariable.Pluralnoun1 = pluralnoun1;
      myMadVariable.Pluralnoun2 = pluralnoun2;
      myMadVariable.Pluralnoun3 = pluralnoun3;
      myMadVariable.Game = game;
      myMadVariable.Verbing1 = verbing1;
      myMadVariable.Verbing2 = verbing2;
      return View(myMadVariable);
    }
  }
}