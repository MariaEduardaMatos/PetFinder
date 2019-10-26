using PetFinderAplication.AplicationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetFinder.Web.Controllers
{
    public class RacaController : Controller
    {
        private readonly RacaAppService _appservice;
        public RacaController (RacaAppService appService)
        {
            _appservice = appService;
        }
        
    }
}