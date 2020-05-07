using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPI
{
    class ApiConsumer
    {
        public static Uri createURL (string appendValue)
        {
            UriBuilder baseURI = new UriBuilder("https://localhost:5001/weight");

            if (baseURI.Query != null && baseURI.Query.Length > 1)
            {
                baseURI.Query = baseURI.Query.Substring(1) + "&" + appendValue;
            }
            else 
            {
                baseURI.Query = appendValue;
            }

            Uri uri = baseURI.Uri;

            return uri;

        }

        public static async Task<Course> pullJSON(Uri uri )
        {

            HttpResponseMessage response = await ApiService.apiClient.GetAsync(uri);

            

                if (response.IsSuccessStatusCode)
                {

                Course result = await response.Content.ReadAsAsync<Course>();
               // CourseData test = await response.Content.ReadAsAsync<CourseData>();

                var jsonString = await response.Content.ReadAsStringAsync();
               string  jsonString2 = await response.Content.ReadAsStringAsync();
               var jsonObj = JsonConvert.DeserializeObject<List<CourseData>>(jsonString2);





                return jsonObj;

                }

                else
                {

                    throw new Exception (response.ReasonPhrase);
                }

            

            
        }



    }
}
