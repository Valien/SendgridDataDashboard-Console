using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SendgridStatsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://sendgrid.com/api/profile.get.json?&");
            
            client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));
                        
            Console.Write("Enter API User: ");
            string apiUser = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter API Key: ");
            string apiKey = Console.ReadLine();
            Console.WriteLine();

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api_user=" + apiUser +"&" + "api_key=" + apiKey).Result; // + "api/stats.get.json?").Result;
            if (response.IsSuccessStatusCode)
            {
                // parse
                var profileData = response.Content.ReadAsAsync<IEnumerable<Profile>>().Result;
                foreach (var s in profileData)
                {
                    Console.WriteLine(("Username: {0}"), s.username);
                    Console.WriteLine(("Email: {0}"), s.email);
                    Console.WriteLine(("Active: {0}"), s.active);
                    Console.WriteLine(("First Name: {0}"), s.first_name);
                    Console.WriteLine(("Last Name: {0}"), s.last_name);
                    Console.WriteLine(("Address: {0}"), s.address);
                    Console.WriteLine(("Address 2: {0}"), s.address2);
                    Console.WriteLine(("State: {0}"), s.state);
                    Console.WriteLine(("Zip: {0}"), s.zip);
                    Console.WriteLine(("Phone: {0}"), s.phone);
                    Console.WriteLine(("Website: {0}"), s.website);
                    Console.WriteLine(("Website Access: {0}"), s.website_access);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

        }
    }
}