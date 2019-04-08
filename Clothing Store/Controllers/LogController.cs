using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clothing_Store.Models;
using Clothing_Store.DAL;

namespace Clothing_Store.Controllers
{
    public class LogController : Controller
    {
        // GET: Log
        public ActionResult Index()
        {
            using (ShopContext shopContext = new ShopContext())
            {
                return View(shopContext.Customers.ToList());
            }
        }
        public ActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult Login(customer customer)
        {
            using (ShopContext shopContext = new ShopContext())
            {
                var usr = shopContext.Customers.Single(u => u.email == customer.email && u.pass == customer.pass);
                
                        if (usr!=null)
                        {
                    Session["ID"] = customer.ID.ToString();
                    Session["email"] = customer.email.ToString();
                    return RedirectToAction("LoggedIn");
                        }
                        else
                {
                    ModelState.AddModelError("", "Username or pass wrong");

                }
            }
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(customer customer)
        {
            if(ModelState.IsValid)
            {
                using (ShopContext shopContext = new ShopContext())
                {
                    shopContext.Customers.Add(customer);
                    shopContext.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = customer.c_name + " Registered";
                
            }
            return View();
        }
        public ActionResult LoggedIn()
        {
            if(Session["ID"]!=null)
            {
                using (ShopContext shopContext = new ShopContext()) {
                    var products = shopContext.Products.ToList();
                return View(products);
                }
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

    }
}