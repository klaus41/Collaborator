using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Context
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<CollaboratorContext>
    {
        protected override void Seed(CollaboratorContext context)
        {


            SearchCriteria sc1 = context.SearchCriterias.Add(new SearchCriteria() { Criteria = "Google" });
            SearchCriteria sc2 = context.SearchCriterias.Add(new SearchCriteria() { Criteria = "klaus" });
            SearchCriteria sc3 = context.SearchCriterias.Add(new SearchCriteria() { Criteria = "Ronni" });
            SearchCriteria sc4 = context.SearchCriterias.Add(new SearchCriteria() { Criteria = "Henry" });
            SearchCriteria sc5 = context.SearchCriterias.Add(new SearchCriteria() { Criteria = "Carsten" });

       

            Email email1 = context.Emails.Add(new Email()
            {
                
                BodyText = "Første bodytext Første bodytext Første bodytext Første bodytext Første bodytext Første bodytext" +
                            "Første bodytext Første bodytext Første bodytext Første bodytext ",
                Recipiant = "klausgaarde@live.dk",
                Sender = "Carsten@eliteit.dk",
                Subject = "Collaborator",
                ReceivedDate = DateTime.Now,              
                SearchCriteria = { sc1, sc4, sc5 }
            });

            Email email2 = context.Emails.Add(new Email()
            {
                
                BodyText = "Anden bodytext Anden bodytext Anden bodytext Anden bodytext Anden bodytext Anden bodytext Anden" +
                            "Anden bodytext Anden bodytext Anden bodytext Anden bodytext Anden bodytext ",
                Recipiant = "klausgaarde@live.dk",
                Sender = "Carsten@eliteit.dk",
                Subject = "Arbejder",
                ReceivedDate = DateTime.Now,
                SearchCriteria = { sc1, sc2 }
            });

            Theme theme1 = context.Themes.Add(new Theme() { Title = "TestTheme1", SearchCriterias = { sc1, sc4, sc5 } });
            Theme theme2 = context.Themes.Add(new Theme() { Title = "TestTheme2", SearchCriterias = { sc2, sc3, sc5 } });

            base.Seed(context);
        }
    }
}