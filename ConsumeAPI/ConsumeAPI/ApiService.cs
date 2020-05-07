using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPI
{
    public class ApiService
    {
        //basic functions of any API call. 
        public static HttpClient apiClient { get; set; } //static there can only be one TCP/IP =time

        public static void InitialiseAPI()
        {
            // initialise apiClient:

            apiClient = new HttpClient();
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


         

               
            



        }

    }
}
