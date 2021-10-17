using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AlGulumVerGulum.BLL.Abstract;
using AlGulumVerGulum.BLL.Utility.Messages;
using AlGulumVerGulum.DTO.UserDtos;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Yazilim129.CORE.Model;

namespace AlGulumVerGulum.Web.MVC.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;

        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("login")]
        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View(new UserLoginDto());
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(UserLoginDto dto)
        {
            if (ModelState.IsValid)
            {
                var loginResult = userService.Login(dto);

                if (loginResult.Type == ResultType.Success)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,loginResult.Data.Id.ToString()),
                        new Claim(ClaimTypes.Email,loginResult.Data.Email),
                        new Claim(ClaimTypes.Name,loginResult.Data.Name)
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                   await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return Redirect((string)TempData["returnUrl"]);
                }
                else
                {
                    ViewBag.Hatali = loginResult.Message;
                }
            }

            return View(dto);
        }
    }
}
