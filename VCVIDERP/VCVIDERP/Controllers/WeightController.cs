using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VCVIDERP.Factory;
using VCVIDERP.LogicManager;
using VCVIDERP.Models;


namespace VCVIDERP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeightController : ControllerBase
    {
  
        [HttpGet]
        public List<Course> Get()
        {

            CourseFactory courseFactory = new CourseFactory();
            ICourseManager courseManager = courseFactory.getCourse("BCOM");
            List<Course> bcadReturnedData = courseManager.getCourseData();
            return bcadReturnedData;

        }
    }

}
