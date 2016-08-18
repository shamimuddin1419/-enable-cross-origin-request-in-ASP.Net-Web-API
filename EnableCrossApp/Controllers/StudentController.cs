using EnableCrossApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnableCrossApp.Controllers
{
    public class StudentController : ApiController
    {
        // StudentMgtEntites object point
        private StudentMgtEntities _dbContext = null;
        // Constructor 
        public StudentController()
        {
            // create instance of an object
            _dbContext = new StudentMgtEntities();
        }
        [HttpGet]
        // Get Students List
        public IEnumerable<Student> GetStudents()
        {
            List<Student> students = _dbContext.Students.ToList();
            return students;
        }
    }
}
