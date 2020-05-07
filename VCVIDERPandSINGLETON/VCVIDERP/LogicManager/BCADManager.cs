using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VCVIDERP.Models;


namespace VCVIDERP.LogicManager
{
    public class BCADManager : ICourseManager
    {

        List<Course> bcadData = new List<Course>();
        public List<Course> getCourseData()
        {
            using(var context = new CollegeERPContext())
            {


                List<Weight> weight = context.Weight.ToList();
                List<ModuleNames>  moduleNames = context.ModuleNames.ToList();
                List<ModuleTypes> moduleTypes = context.ModuleTypes.ToList();

                

                bcadData.Add(
                    new Course
                    {
                         ModuleName = moduleNames.Find(n => n.ModuleName == "PROGf5111"),
                         WeightFormative1 = weight.Find(n=> n.WeightValue ==10),
                         WeightFormative2 = weight.Find(n=>n.WeightValue ==20),
                         WeightFormative3 = weight.Find(n=>n.WeightValue==20),
                         ModuleType = moduleTypes.Find(n=>n.NumFormative==3)});


                bcadData.Add(
                  new Course
                  {
                      ModuleName = moduleNames.Find(n => n.ModuleName == "PRLD5111"),
                      WeightFormative1 = weight.Find(n => n.WeightValue == 10),
                      WeightFormative2 = weight.Find(n => n.WeightValue == 30),
                      WeightFormative3 = weight.Find(n => n.WeightValue == 10),
                      ModuleType = moduleTypes.Find(n => n.NumFormative== 3)
                  });
                return bcadData;
            }
                
        }  
    }
}

