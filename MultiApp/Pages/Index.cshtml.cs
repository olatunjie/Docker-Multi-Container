using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {
            using (var client = new System.Net.Http.HttpClient())
            {
                var request = new System.Net.Http.HttpRequestMessage();
                request.RequestUri = new Uri("http://multiapi/api/BabyName");
                var response = await client.SendAsync(request);
                var babyname = await response.Content.ReadAsStringAsync();

                var details = JObject.Parse(babyname);
                ViewData["BabyName"] = details["name"] + ";;" + details["englishMeaning"];
            }
        }
    }
}
