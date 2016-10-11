using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPI.EmailManager;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public void GetSaveAndIndexEmails()
        {
            string userName = "klaus@eliteit.dk";
            string password = "Kg240789.";

            EmailReader er = new EmailReader();
            EmailWriter ew = new EmailWriter();
            Indexer indexer = new Indexer();
            List<Email> emails;
            FindItemsResults<Item> findResults;

            findResults = er.GetAllEmails(userName, password);
            emails = ew.EmailConverter(findResults, userName);
            ew.SaveEmails(emails);
            indexer.IndexAllEmails();
        }
    }
}
