﻿using JeuDotnetEstLeHeros.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeudontonestleheros.Core.Data;

namespace JeuDotnetEstLeHeros.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.MonTitre = "Aventures";

            List<Aventure> maList = new List<Aventure>();

            maList.Add(new Aventure()
            {
                Id = 1,
                Titre = "Ma première aventure"
            });

            maList.Add(new Aventure()
            {
                Id = 2,
                Titre = "Ma seconde aventure"
            });

            return View(maList);
        }
    }
}
