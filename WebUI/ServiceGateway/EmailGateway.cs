using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebUI.Models;

namespace CollaboratorUI.ServiceGateway
{
    public class EmailGateway : Client
    {
        public IEnumerable<Email> GetEmails()
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = client.GetAsync("api/emails/").Result;
            var emails = response.Content.ReadAsAsync<IEnumerable<Email>>().Result;
            return emails;
        }

        public Email GetEmail(int id)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = client.GetAsync("api/emails/" + id.ToString()).Result;
            var email = response.Content.ReadAsAsync<Email>().Result;
            return email;
        }
    }
}