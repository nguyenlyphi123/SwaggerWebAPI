using CoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        SchoolContext data = new SchoolContext();
        
        [HttpGet]
        public JsonResult Get()
        {
            var classList = from cl in data.Classes select cl;
            return new JsonResult(classList);
        }

        [HttpPost]
        public String Post(Class cl)
        {
            try
            {
                data.Classes.Add(cl);
                data.SaveChanges();

                return "Add successfull";
            }
            catch (Exception e)
            {
                return "Add fail";
            }
        }

        [HttpPut]
        public string Put(Class cl)
        {
            try
            {
                var newClass = data.Classes.SingleOrDefault(n => n.ClassId == cl.ClassId);
                newClass.ClassName = cl.ClassName;
                data.SaveChanges();

                return "Update successfully";
            }
            catch (Exception)
            {
                return "Update Fail";
            }
        }
    }
}
