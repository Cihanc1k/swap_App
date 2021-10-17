using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AlGulumVerGulum.Web.MVC.UI.Controllers
{
    public class NoticeController : Controller
    {
        [Route("ilanlar")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ilan-detayi")]
        public IActionResult Detail()
        {
            return View();
        }

        [Authorize]
        [Route("ilan-olustur")]
        public IActionResult CreateNotice()
        {
            return View();
        }
    }
}
