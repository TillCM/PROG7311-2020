using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VCVIDERP.Models;

namespace VCVIDERP.LogicManager
{
    public class Course
    {

        public ModuleNames ModuleName { get; set; }
        public Weight WeightFormative1 { get; set; }
        public Weight WeightFormative2 { get; set; }

        public Weight WeightFormative3 { get; set; }

        public Weight WeightFormative4 { get; set; }
        
        public ModuleTypes ModuleType  { get; set; }
    }
}
