using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsumeBackEnd.Models;
using System.Net.Http;
using System.Threading;
using AccountsCodingTest.Models;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace ConsumeBackEnd.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> GetAllAsync()
        {
            var Url = "http://localhost:7071/api/accounts/getall";
            CancellationToken cancellationToken;

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Get, Url))
            using (var response = await client
                .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                .ConfigureAwait(false))
            {
                var result = await response.Content.ReadAsAsync<List<Account>>();

                ViewData["AccountsList"] = result;             
            }

            return View("GetAll");
        }     
    }
}
