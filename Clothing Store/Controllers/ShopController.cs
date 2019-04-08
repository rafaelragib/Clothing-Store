 using Clothing_Store.DAL;
using Clothing_Store.Models;
using Clothing_Store.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clothing_Store.Controllers
{
    public class ShopController : Controller
    {
        ShopContext db = new ShopContext();
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Cart()
        //{
        //    return View();
        //}
        public ActionResult searchbycategory(String category)
        {
            
            if (category == "Male")
            {
                using (ShopContext shopContext = new ShopContext())
                {
                    return View(shopContext.Products.Where(x => x.CategoryID == 1).ToList());
                }

            }
            else
            {
                return View();
            }

        }
        [ActionName("product-details")]
        public ActionResult ProductDetails(int id)
        {
            Product model;
            
            using (ShopContext shopContext = new ShopContext())
            {
                if (!shopContext.Products.Any(x => x.ProductID.Equals(id)))
                {
                    return RedirectToAction("Index", "Log");
                }
                model = shopContext.Products.Where(x => x.ProductID == id).FirstOrDefault();
                id = model.ProductID;
            }
            return View("ProductDetails", model);
        }
        public ActionResult AddToCartPartial(int id)
        {
            List<CartVM> cart = Session["cart"] as List<CartVM> ?? new List<CartVM>();

            CartVM model = new CartVM();
            using (ShopContext shopContext = new ShopContext())
            {
                Product product =S
            }
                return View();
        }
    }
}