using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using JustFood.Modules.Extensions;
using JustFood.Modules.TimeZone;
using Microsoft.Ajax.Utilities;
using DB = JustFood.Models;
using JustFood.Modules.Query;
using JustFood.Modules.Session;
using JustFood.Modules.Cookie;
using JustFood.Modules.Cache;
using JustFood.Models;
using JustFood.Modules.StaticContents;
using JustFood.Modules.Message;
using JustFood.Areas.Admin.Controllers;

namespace JustFood.Areas.Sale.Controllers {
    public class HomeController : Controller {
        readonly DB.JustFoodDBEntities db;
        readonly UserInfo userinfo;
        Exception exceptionNoRights = new Exception("Sorry you have no rights to process this function. Please contact with respective admin for more details.");

        public HomeController() {
            db = new DB.JustFoodDBEntities();
            userinfo = new UserInfo();
        }

        #region Extention Methods and Propertise


        /// <summary>
        /// Check and save current time.
        /// </summary>
        /// <param name="time"></param>
        /// <returns>Checks and returns if times are equal or not from the cookie and then save the cookie.</returns>
        bool IsCookieTimeEqual(string time) {
            string ctime = CookieTime;
            //save current time to cookie.
            CookieTime = time;
            if (ctime != null && time != null && time.Equals(ctime)) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// checks null and return the value.
        /// </summary>
        /// <param name="sale"></param>
        /// <returns></returns>
        bool IsToday(DB.Sale sale) {
            if (sale != null) {
                if (sale.Date.Date == DateTime.Now.Date) {
                    return true;
                }
            }
            return false;
        }

        public String CookieTime {
            get {
                return Statics.Cookies.ReadString(CookiesNames.Time);
            }
            set {
                Statics.Cookies.Save(value, CookiesNames.Time);
            }
        }

        public string CookieIsInventoryEmpty {
            get {
                return Statics.Cookies.ReadString(CookiesNames.InventoryEmpty);
            }
            set {
                Statics.Cookies.Save(value, CookiesNames.InventoryEmpty);
            }
        }


        /// <summary>
        /// Keep only today's sale.
        /// </summary>
        public DB.Sale CacheSale {
            get { return (DB.Sale)Statics.Caches.Get(CacheNames.Sale); }
            set { Statics.Caches.Set(CacheNames.Sale, value); }
        }
        #endregion

        public ActionResult Index() {

            string date = Zone.GetDate(DateTime.Now);

            return View();
        }

        #region Searching

        DB.Sale GetToday() {
            DB.Sale sale;
            sale = CacheSale;
            if (sale != null && IsToday(sale)) {
                try {
                    db.Entry(sale).State = EntityState.Modified;
                } catch (Exception ex) { }
                return sale;
            }
            DateTime date = DateTime.Now.Date;
            sale = db.Sales.FirstOrDefault(n => n.Date == date);
            CacheSale = sale;
            return sale;
        }

        private DB.Sale GetDatedSale(DateTime date) {
            var dated = date.Date;
            DB.Sale sale = CacheSale;
            if (sale != null && IsToday(sale)) {
                try {
                    db.Entry(sale).State = EntityState.Modified;
                } catch (Exception ex) { }
                return sale;
            }
            sale = db.Sales.FirstOrDefault(n => n.Date == dated);
            CacheSale = sale;
            return sale;
        }

        /// <summary>
        /// Will be added with the context.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private DB.Sale GetDatedSale(int id) {
            DB.Sale sale = CacheSale;
            if (sale != null && IsToday(sale)) {
                try {
                    db.Entry(sale).State = EntityState.Modified;
                } catch (Exception ex) { }
                return sale;
            }
            sale = db.Sales.Find(id);
            CacheSale = sale;
            return sale;
        }

        Inventory GetInventory(int CategoryID) {
            return db.Inventories.FirstOrDefault(n => n.CategoryID == CategoryID);
        }
        #endregion


        protected override void Dispose(bool disposing) {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}