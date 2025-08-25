using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using med_supply.Models;
using System.Web.Mvc;

namespace med_supply.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        abdata context=new abdata();
        
        public ActionResult Index()
        {
            //var res=context.tbl_comm.ToList();
            var res = context.tbl_comm.ToList();

            ViewBag.title = res.Where(x=>x.Name== "تیتراصلی").Select(x=>x.valuee).SingleOrDefault();
            ViewBag.bannerimg= res.Where(x => x.Name == "عکس بنر").Select(x => x.valuee).SingleOrDefault();
            ViewBag.bannerimg2 = res.Where(x => x.Name == "عکس بنردو").Select(x => x.valuee).SingleOrDefault();
            return View();
        }

        public ActionResult layout()
        {
            return View();
        }

        public ActionResult about()
        {
            return View();
        }

        public ActionResult contact()
        {
            return View();
        }

        public ActionResult Shop()
        {
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }
         public ActionResult checkOut()
        {
            return View();
        }

        public ActionResult thankyou()
        {
            return View();
        }
        public ActionResult shopSingle()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult CallUs()
        {
            return View();
        }

        public ActionResult Picture()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }

        public ActionResult code1()
        {
            return View();
        }
        public ActionResult code2()
        {
            return View();
        }

    }
    }

