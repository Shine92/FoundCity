﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoundCity_V2.Controllers
{
    public class PetController : Controller
    {
        // GET: Pet
        public ActionResult Index()
        {
            return View();
        }
    }
}