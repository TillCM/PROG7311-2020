using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeJSONV3.Models
{
    class NestedCourseInfo
    {

        public ModuleName moduleName { get; set; }
        public WeightFormative1 weightFormative1 { get; set; }
        public WeightFormative2 weightFormative2 { get; set; }
        public WeightFormative3 weightFormative3 { get; set; }
        public  WeightFormative4 weightFormative4 { get; set; }
        public ModuleType moduleType { get; set; }
    }
}
