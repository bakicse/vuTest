using System.Net.Http;
using vuTest.Model;

namespace vuTest.Service
{
    public class CheckoutService(HttpClient httpClient)
    {
        public async Task<string> CreateCheckoutUrlAsync(SubscriptionModel subscription)
        {
            httpClient.DefaultRequestHeaders.Add("api-key", "796b8b9dbbf46b1d8fd73f68979ae31635da9afabc9dee147adf0440ee7118a8");

            var response = await httpClient.PostAsJsonAsync(
                "https://bkashtest.shabox.mobi/home/MultiTournamentInBuildCheckoutUrl",
                subscription);

            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
