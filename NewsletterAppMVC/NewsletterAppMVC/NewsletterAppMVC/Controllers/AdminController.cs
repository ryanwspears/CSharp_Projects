﻿using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signups = db.SignUpTables.Where(x => x.Removed == null).ToList();
                var signupVms = new List<SignupVm>();

                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.Email = signup.Email;
                    signupVms.Add(signupVm);
                }

                return View(signupVms);
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using(NewsletterEntities db = new NewsletterEntities())
            {
                var signup = db.SignUpTables.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}