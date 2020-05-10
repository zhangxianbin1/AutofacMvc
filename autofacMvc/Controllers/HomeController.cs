using IService;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace autofacMvc.Controllers
{
    public class HomeController : Controller
    {
        private IUserService userService;
        //通过构造器注入依赖
        public HomeController(IUserService _userService)
        {
            userService = _userService;
        }
        public ActionResult Index()
        {
            //不使用autofac时，service层和mvc ui层强耦合
            //UserInfoService userInfoService = new UserInfoService();
            //List<UserInfo> users= userInfoService.GetUsers();

            List<user> users = userService.GetUsers();
            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}