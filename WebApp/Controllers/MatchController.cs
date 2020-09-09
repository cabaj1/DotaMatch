using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class MatchController : Controller
    {
        public IActionResult Index()
        {
            MatchIndexViewModel matchIndexViewModel = new MatchIndexViewModel()
            {
                Creators = "2x Matthias"
            };
            return View(matchIndexViewModel);
        }
        [Route("Match/{matchid:int}")]
        public IActionResult Game(int matchid) 
        {
            MatchGameViewModel matchGameViewModel = new MatchGameViewModel()
            {

                MatchId = matchid
            };


            return View(matchGameViewModel);
        }
    }
}