using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VMR.Models;

namespace VMR.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Add(AlbumInfo item)
        {
            vmrdataEntities db = new vmrdataEntities();

            db.AlbumInfoes.Add(item);

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Browse()
        {
            vmrdataEntities ORM = new vmrdataEntities();
            List<AlbumInfo> ItemList = ORM.AlbumInfoes.ToList();
            ViewBag.ItemList = ItemList;
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Sell()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Confirm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cart(string AddProduct)
        {
            List<AlbumInfo> ShoppingBag; // reference to null 
            if (Session["Cart"] == null)// the cart is empty! 
            {
                Session.Add("Cart", new List<AlbumInfo>());
                ShoppingBag = new List<AlbumInfo>();
            }
            else// user has items in the cart, so go and retrive it!
            {
                ShoppingBag = (List<AlbumInfo>)Session["Cart"];
            }
            ///////////////////////////
            vmrdataEntities DB = new vmrdataEntities();


            AlbumInfo Option = DB.AlbumInfoes.Find(AddProduct);
           ShoppingBag.Add(Option);
            Session["Cart"] = ShoppingBag;// save changes you made to your cart! 

            ViewBag.PList = ShoppingBag;

            // 
            double sum = 0;

            for (int i = 0; i <ShoppingBag.Count; i++)
            {
                sum= sum + ShoppingBag[i].Price;
            }
            
           ViewBag.Sum = sum;
            return View("Checkout");

        }


    }
}