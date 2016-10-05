using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class CollaboratorContext : DbContext
    {
        public CollaboratorContext(): base("Collaboratorv2")
        {
            Database.SetInitializer(new ContextInitializer());
        }
        public DbSet<Email> Emails { get; set; }

        public DbSet<SearchCriteria> SearchCriterias { get; set; }

        public System.Data.Entity.DbSet<WebAPI.Models.Theme> Themes { get; set; }
    }
}