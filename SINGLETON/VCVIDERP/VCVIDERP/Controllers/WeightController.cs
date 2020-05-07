using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logger;
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
        private readonly ILogger<WeightController> logger;
        Ilog ilog;
        public WeightController(ILogger<WeightController> logger)
        {

            
            ilog = Log.GetInstance;
            this.logger = logger;
            String error =$"Error occured on{DateTime.Now.ToLongTimeString()}" + " " + "$ Error =" ;
            
           ilog.logException(error);
        } 

        
  
        [HttpGet]
        public List<Course> Get(string courseParemeter="BCAD")
        {

            CourseFactory courseFactory = new CourseFactory();
            ICourseManager courseManager = courseFactory.getCourse(courseParemeter);
            List<Course> bcadReturnedData = courseManager.getCourseData();
            return bcadReturnedData;

        }

       
    }

}
