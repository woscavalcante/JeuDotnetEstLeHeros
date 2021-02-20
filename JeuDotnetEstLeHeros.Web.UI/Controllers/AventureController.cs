using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JeuDotnetEstLeHeros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventures";
            this.ViewBag.MonTableau = new int[] { 1, 2, 3, 4, 5 };

            return View();
        }
    }
}
