using RadioCabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RadioCabs.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class PanelController : Controller
    {
        // GET: Admin/Panel
        
        public ActionResult Index()
        {
            return View();
        }

        #region Listings

        public ActionResult AddListing()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddListing(Listing form)
        {
            if (ModelState.IsValid == false)
                return View(form);

            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            dBContext.listings.Add(form);
            dBContext.SaveChanges();

            return RedirectToAction("ListingsList");
        }

        public ActionResult EditListing(int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var listing = dBContext.listings.Single(x => x.ID == Id);

            return View(listing);
        }
        [HttpPost]
        public ActionResult EditListing(Listing listing, int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var oldListing = dBContext.listings.SingleOrDefault(x => x.ID == Id);
            dBContext.Entry(oldListing).CurrentValues.SetValues(listing);
            dBContext.SaveChanges();

            return RedirectToAction("ListingsList");
        }
        
        public ActionResult DeleteListing(Listing listing, int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            listing = dBContext.listings.Single(x => x.ID == Id);
            dBContext.listings.Remove(listing);
            dBContext.SaveChanges();

            return RedirectToAction("ListingsList");
        }

        public ActionResult ListingDetails(int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var listing = dBContext.listings.Single(x => x.ID == Id);
            return View(listing);
        }

        public ActionResult ListingsList(Listing abc)
        {
            RadioCabsDBContext radioCabsDB = new RadioCabsDBContext();
            List<Listing> listings = radioCabsDB.listings.ToList();
            return View(listings);
        }

        #endregion

        #region Drivers

        public ActionResult AddDriver()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddDriver(Driver form)
        {
            if (ModelState.IsValid == false)
                return View(form);

            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            dBContext.drivers.Add(form);
            dBContext.SaveChanges();

            return RedirectToAction("DriversList");
        }
        
        public ActionResult EditDriver(int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var driver = dBContext.drivers.Single(x => x.ID == Id);

            return View(driver);
        }
        [HttpPost]
        public ActionResult EditDriver(Driver driver, int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var oldDriver = dBContext.drivers.SingleOrDefault(x => x.ID == Id);
            dBContext.Entry(oldDriver).CurrentValues.SetValues(driver);
            dBContext.SaveChanges();

            return RedirectToAction("DriversList");
        }
        
        public ActionResult DeleteDriver(Driver driver, int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            driver = dBContext.drivers.Single(x => x.ID == Id);
            dBContext.drivers.Remove(driver);
            dBContext.SaveChanges();

            return RedirectToAction("DriversList");
        }

        public ActionResult DriverDetails(int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var drivers = dBContext.drivers.Single(x => x.ID == Id);
            return View(drivers);
        }

        public ActionResult DriversList(Listing abc)
        {
            RadioCabsDBContext radioCabsDB = new RadioCabsDBContext();
            List<Driver> drivers = radioCabsDB.drivers.ToList();
            return View(drivers);
        }

        #endregion

        #region Advertisement
        public ActionResult NewAdvertise()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAdvertise(Advertisement form)
        {
            if (ModelState.IsValid == false)
                return View(form);

            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            dBContext.advertisements.Add(form);
            dBContext.SaveChanges();

            return RedirectToAction("AdvertiseList");
        }

        public ActionResult EditAdvertise(int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var advertise = dBContext.advertisements.Single(x => x.ID == Id);

            return View(advertise);
        }
        [HttpPost]
        public ActionResult EditAdvertise(Advertisement advertise, int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var oldAdvertise = dBContext.advertisements.SingleOrDefault(x => x.ID == Id);
            dBContext.Entry(oldAdvertise).CurrentValues.SetValues(advertise);
            dBContext.SaveChanges();

            return RedirectToAction("AdvertiseList");
        }

        public ActionResult DeleteAdvertise(Advertisement advertise, int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            advertise = dBContext.advertisements.Single(x => x.ID == Id);
            dBContext.advertisements.Remove(advertise);
            dBContext.SaveChanges();

            return RedirectToAction("AdvertiseList");
        }

        public ActionResult AdvertiseDetails(int Id)
        {
            RadioCabsDBContext dBContext = new RadioCabsDBContext();
            var advertise = dBContext.advertisements.Single(x => x.ID == Id);
            return View(advertise);
        }

        public ActionResult AdvertiseList()
        {
            RadioCabsDBContext radioCabsDB = new RadioCabsDBContext();
            List<Advertisement> advertisements = radioCabsDB.advertisements.ToList();
            return View(advertisements);
        }

        #endregion

    }
}