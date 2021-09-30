using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EntityFrameworkDbContext.Controllers
{
    public class HomeController : Controller
    {
        ShopDbContext db = new ShopDbContext();
        public ActionResult Index()
        {
            string chuoi = "";
            var query = db.News.ToList();
            foreach (var item in query)
            {
                chuoi += item.Title + "<br>";
                chuoi += item.Brief + "<br>";
            }
            ViewBag.Hienthi = chuoi;
            return View();
        }

        public JsonResult Send(int id)
        {

            if (id > 0)
            {
                return Json(new
                {
                    status = true,
                    message = "Thành công",
                    TrangThai = "Đạt"
                });
                //send mail
            }

            else
                return Json(new
                {
                    status = false,
                    message = "Lỗi không thành công",
                    TrangThai = "Không đạt"
                });

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