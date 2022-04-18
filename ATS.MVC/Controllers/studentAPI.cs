using ATS.MVC.Models;
using ATS.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATS.MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentAPIController : ControllerBase
    {
        private readonly IStudent studentService;
        private readonly IDepartment deptService;
        public studentAPIController(IStudent _studentService, IDepartment _deptService)
        {
            studentService = _studentService;
            deptService = _deptService;
        }
        // GET: api/<studentAPI>
        [HttpGet]
        public IEnumerable<Student> GetAllStudents()
        {
                           var stdLst1 = from a in studentService.GetStudents()
                              join b in deptService.getAllDepartment()
                              on a.DepID equals b.Id
                              into Dept
                              from b in Dept.DefaultIfEmpty()
                              select new Student
                              {
                                  ID = a.Id,
                                  Name = a.Name,
                                  Email = a.Email,
                                  Mobile = a.Mobile,
                                  Department = b == null ? "" : b.Department
                              };
                List<Student> stdLst = new List<Student>();
                foreach (var x in stdLst1)
                {
                    Student ob = new Student
                    {
                        ID = x.ID,
                        Name = x.Name,
                        Email = x.Email,
                        Mobile = x.Mobile,
                        Department = x.Department
                    };
                    stdLst.Add(ob);
                }
                return (stdLst);
            }
         
        
    }

        //// GET api/<studentAPI>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<studentAPI>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<studentAPI>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<studentAPI>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }

