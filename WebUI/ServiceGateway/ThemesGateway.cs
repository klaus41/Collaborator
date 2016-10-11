using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebUI.Models;

namespace CollaboratorUI.ServiceGateway
{
    public class ThemesGateway : Client
    {
        public IEnumerable<Theme> GetThemes()
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = client.GetAsync("api/themes/").Result;
            var theme = response.Content.ReadAsAsync<IEnumerable<Theme>>().Result;
            return theme;
        }

        public Theme GetTheme(int id)
        {
            HttpClient client = GetHttpClient();
            HttpResponseMessage response = client.GetAsync("api/themes/" + id.ToString()).Result;
            var theme = response.Content.ReadAsAsync<Theme>().Result;
            return theme;
        }
    }
}