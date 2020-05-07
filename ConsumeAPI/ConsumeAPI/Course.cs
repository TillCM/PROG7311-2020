using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeAPI
{
    class Course
    {
        public ModuleName moduleName { get; set; }
        public WeightFormative1 weightFormative1 { get; set; }
        public WeightFormative2 weightFormative2 { get; set; }
        public WeightFormative3 weightFormative3 { get; set; }
        public  weightFormative4 weightFormative4 { get; set; }
        public ModuleType moduleType { get; set; }
    }
}
