using ConsumeJSONV2.NestedCourse;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeJSONV2
{
    class ApiService
    {
        public static List<CourseData> data { get; set; }

        public static   Uri createURL(string appendValue)
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

        public static string stringApiCall(Uri uri)
        {
            using (var webClient = new WebClient())
            {
                string JSON = webClient.DownloadString(uri);

                return JSON;
            }
        }



        public static  List<CourseData> pullNestedObjects(Uri uri)
        {
            using (var webClient = new WebClient())
            {
                string JSON = webClient.DownloadString(uri);

                var fetch = JsonConvert.DeserializeObject<NestedCourseInfo[]>(JSON);

                
                List<CourseData> course = new List<CourseData>();


                foreach (var item in fetch)
                {
                    course.Add(new CourseData { moduleName= item.moduleName.moduleName, weightFormative1= item.weightFormative1.weightValue,
                    weightFormative2 = item.weightFormative2.weightValue, weightFormative3 = item.weightFormative3.weightValue});

                }

        
                return course;

            }




        }
     


    }
}
