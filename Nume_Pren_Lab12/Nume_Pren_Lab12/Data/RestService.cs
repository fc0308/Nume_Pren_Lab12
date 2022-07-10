using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Nume_Pren_Lab12.Models;

namespace Nume_Pren_Lab12.Data
{
    public class RestService : IRestService
    {
        HttpClient client;
        
        string RestUrl = "https://169.254.31.248:45457/api/sales";
      

        public List<Sales> ChartItems { get; private set; }
        public RestService()

        {
          
            var httpClientHandler = new HttpClientHandler();

            httpClientHandler.ServerCertificateCustomValidationCallback =
            (message, cert, chain, errors) => { return true; };

            client = new HttpClient(httpClientHandler);

        }

        public async Task<List<Sales>> RefreshDataChartAsync()
        {
            ChartItems = new List<Sales>();

            Uri uri = new Uri(string.Format(RestUrl, string.Empty));
            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    ChartItems = JsonConvert.DeserializeObject<List<Sales>>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return ChartItems;
        }

    
    }
}
