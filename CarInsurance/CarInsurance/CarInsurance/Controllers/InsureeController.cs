using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                insuree.Quote = QuotePrice(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                insuree.Quote = QuotePrice(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public decimal QuotePrice(Insuree insuree)
        {
            decimal monthlyPrice = 50.00m;

            int age = DateTime.Now.Subtract(insuree.DateOfBirth).Days;
            age = age / 365;

            // Age Check
            if(age <= 18)
            {
                monthlyPrice += 100.00m;
            }
            else if(age >= 19 && age <= 25)
            {
                monthlyPrice += 50.00m;
            }
            else if(age > 25)
            {
                monthlyPrice += 25.00m;
            }

            // Year Model Check
            if(insuree.CarYear < 2000)
            {
                monthlyPrice += 25.00m;
            }
            else if(insuree.CarYear > 2015)
            {
                monthlyPrice += 25.00m;
            }

            // Check for Porsche & 911 Carrera
            if (insuree.CarMake == "porsche" || insuree.CarMake == "Porsche")
            {
                monthlyPrice += 25.00m;

                if (insuree.CarModel == "911 Carrera" || insuree.CarMake == "911 carrera")
                {
                    monthlyPrice += 25.00m;
                }
            }

            // Check for Speeding Tickets
            int ticketPrice = insuree.SpeedingTickets * 10;

            if(insuree.SpeedingTickets > 0)
            {
                monthlyPrice += ticketPrice;
            }

            // Check for DUI
            if(insuree.DUI == true)
            {
                decimal num = monthlyPrice * Convert.ToDecimal(.25);
                monthlyPrice += num;
            }

            // Check for Full Coverage
            if(insuree.CoverageType == true)
            {
                decimal num = monthlyPrice *= Convert.ToDecimal(.5);
                monthlyPrice += num;
            }

            return monthlyPrice;
        }
    }
}
