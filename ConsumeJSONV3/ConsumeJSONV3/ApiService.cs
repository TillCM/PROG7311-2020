using ConsumeJSONV3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeJSONV3
{
    class ApiService
    {
        public static Uri createURL(string appendValue)
        {
            UriBuilder baseURL = new UriBuilder("https://localhost:5001/weight");

            if (baseURL.Query != null && baseURL.Query.Length >1)
            {
                baseURL.Query = baseURL.Query.Substring(1) + "&" + appendValue;
            }
            else 
            {

                baseURL.Query = appendValue;
            }

            Uri uri = baseURL.Uri;
            return uri;
        
        }


        public static string stringAPIcall(Uri uri)
        {
            using(var webClient = new WebClient())
            {

                string JSON = webClient.DownloadString(uri);

                return JSON;
            }

        }

        public static List <CourseData> pullNestedOjbects(Uri uri)
        {

            using (var webClient = new WebClient())
            {

                string JSON = webClient.DownloadString(uri);

                var fetch = JsonConvert.DeserializeObject<NestedCourseInfo[]>(JSON);

                List<CourseData> course = new List<CourseData>();

                foreach (var item in fetch)
                {
                    course.Add(new CourseData { moduleName = item.moduleName.moduleName,
                    formative1Weight = item.weightFormative1.weightValue,
                    formative2Weight=item.weightFormative1.weightValue,
                    formative3Weight=item.weightFormative3.weightValue,
                    moduleType= item.moduleType.numFormative});
                }

                return course;
            }

        }

        
    }
}
