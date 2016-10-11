using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI.Context;
using WebAPI.Models;

namespace WebAPI.EmailManager
{
    public class Indexer
    {
        private CollaboratorContext db = new CollaboratorContext();
        DbSet<Email> emails;
        DbSet<SearchCriteria> searchCriterias;


        public void IndexAllEmails()
        {
            emails = db.Emails;
            searchCriterias = db.SearchCriterias;

            foreach (var searchCriteria in searchCriterias)
            {
                foreach (var email in emails)
                {
                    if (email.BodyText.Contains(searchCriteria.Criteria))
                    {
                        email.SearchCriteria.Add(searchCriteria);
                    }
                }
            }
            db.SaveChanges();
        }
    }
}