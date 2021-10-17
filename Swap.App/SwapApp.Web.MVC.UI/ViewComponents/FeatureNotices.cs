using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlGulumVerGulum.Web.MVC.UI.ViewComponents
{
    public class FeatureNotices : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/Components/FeatureNotices.cshtml");
        }
    }
}
