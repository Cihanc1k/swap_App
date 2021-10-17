using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlGulumVerGulum.Web.MVC.UI.ViewComponents
{
    public class Header : ViewComponent
    {
        // standart
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Header.cshtml");
        }
    }
}
