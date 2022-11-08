using Imi.Project.Vue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Vue.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
