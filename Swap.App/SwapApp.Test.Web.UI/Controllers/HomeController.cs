using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AlGulumVerGulum.BLL.Abstract;
using AlGulumVerGulum.BLL.Concrete;
using AlGulumVerGulum.BLL.Utility.Messages;
using AlGulumVerGulum.DAL.Abstract;
using AlGulumVerGulum.DAL.EntityFramework;
using AlGulumVerGulum.DOMAIN.Entities;
using AlGulumVerGulum.Test.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yazilim129.CORE.Utility;

namespace AlGulumVerGulum.Test.Web.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        public HomeController(ICategoryService categoryService)
        {
            categoryService.SelamDur();
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            //var result = _categoryService.Create(new Category { Name = "Test", Description = "Test desc", PicturePath = "picture" });

            // MYNotice = 3
            
            // TargetNotice=1

            // Request=2 (waiting)

            // Envelope (noticeId=3,reqId=2,Role=sender)

            // Envelope (noticeId=1,reqId=2,Role=target)

            // MYNotice = 3

            // TargetNotice = 5

            // Request = 4

            // Env (noticeId=3,reqId=4,Role=sender)
            // Env (noticeId=5,reqId=4,Role=target)

            return View();
        }

       
    }
}