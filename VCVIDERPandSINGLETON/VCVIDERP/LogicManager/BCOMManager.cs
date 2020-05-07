using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VCVIDERP.Models;

namespace VCVIDERP.LogicManager
{
    public class BCOMManager : ICourseManager
    {
        List<Course> bcomData = new List<Course>();

        public List<Course> getCourseData()
        {
            using(var context = new CollegeERPContext())
            {

                List<Weight> weight = context.Weight.ToList();
                List<ModuleNames> moduleNames = context.ModuleNames.ToList();
                List<ModuleTypes> moduleTypes = context.ModuleTypes.ToList();

                bcomData.Add(
                  new Course
                  {
                      ModuleName = moduleNames.Find(n => n.ModuleName == "BMNG5111"),
                      WeightFormative1 = weight.Find(n => n.WeightValue == 10),
                      WeightFormative2 = weight.Find(n => n.WeightValue == 20),
                      WeightFormative3 = weight.Find(n => n.WeightValue == 20),
                      ModuleType = moduleTypes.Find(n => n.NumFormative == 3)
                  });


                bcomData.Add(
                  new Course
                  {
                      ModuleName = moduleNames.Find(n => n.ModuleName == "APCT5111"),
                      WeightFormative1 = weight.Find(n => n.WeightValue == 10),
                      WeightFormative2 = weight.Find(n => n.WeightValue == 30),
                      WeightFormative3 = weight.Find(n => n.WeightValue == 10),
                      WeightFormative4 = weight.Find(n=>n.WeightValue ==20),
                      ModuleType = moduleTypes.Find(n => n.NumFormative == 4)
                  });

                return bcomData;
            
            }


        }
    }
}
