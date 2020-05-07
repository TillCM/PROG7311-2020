using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VCVIDERP.LogicManager;

namespace VCVIDERP.Factory
{
    public class CourseFactory
    {

        ICourseManager requestedCourse;

       public ICourseManager getCourse(string courseName)
        {

            if (courseName == "BCAD")
            {
                requestedCourse = new BCADManager();
            }
            else if (courseName =="BCOM")
            {
                requestedCourse = new BCOMManager();
            }


            return requestedCourse;

        }


    }
}
