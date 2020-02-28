using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Net.Http;
using System.Text;
using System.Net;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AccountsCodingTest.Factories;

namespace AccountsCodingTest.Functions
{
    public static class AccountsFunction
    {
        [FunctionName(nameof(GetAllAccounts))]
        public static Task<HttpResponseMessage> GetAllAccounts(
            [HttpTrigger(AuthorizationLevel.Anonymous, "GET", Route = "accounts/getall")] HttpRequestMessage req,
            ILogger log)
        {
            log.LogInformation($"GetAllAccounts triggered: {req.Method} {req.RequestUri}");
            var accounts = AccountsMockDataFactory.CreateAccountsCollection();
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                RequestMessage = req,
                Content = new StringContent(
                    content: JsonConvert.SerializeObject(accounts),
                    encoding: Encoding.UTF8,
                    mediaType: "application/json"
                )
            };

            return Task.FromResult(response);
        }
    }
}
