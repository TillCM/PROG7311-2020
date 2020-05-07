using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeJSONV3
{
    class CourseData
    {
        public string moduleName { get; set; }
        public int formative1Weight { get; set; }
        public int formative2Weight { get; set; }
        public int formative3Weight { get; set; }
        public int formative4Weight { get; set; }

        public int moduleType { get; set; }

    }
}
