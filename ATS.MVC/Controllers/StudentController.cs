using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATS.MVC.Models;
using ATS.Repositories;
using ATS.Service;
using ATS.Models;

namespace ATS.MVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent studentService;
        private readonly IDepartment deptService;
        public StudentController(IStudent _studentService, IDepartment _deptService)
        {
            studentService = _studentService;
            deptService = _deptService;
        }
        public IActionResult StudentList()
        {
            try
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
                foreach(var x in stdLst1)
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
                return View(stdLst);
            }
            catch (Exception e)
            { return View(); }
        }
        [HttpGet]

        public IActionResult Create(Student ob)
        {
            loadDDL();
            return View(ob);
        }

        [HttpPost]
        public IActionResult AddStudent(Student ob)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    tbl_students ob1 = new tbl_students
                    {
                        Id = ob.ID,
                        Name = ob.Name,
                        Fname = ob.Fname,
                        Email = ob.Email,
                        Mobile = ob.Mobile,
                        DepID = ob.DepID,
                        Description = ob.Description
                    };
                    if (ob.ID == 0)
                    {
                        studentService.InsertStudent(ob1);                        
                        return RedirectToAction("StudentList");
                    }
                    else
                    {
                        studentService.UpdateStudent(ob1);
                        return RedirectToAction("StudentList");
                    }
                }

                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("StudentList");
            }
        }
        public void loadDDL()
        {
            List<Departments> depList = new List<Departments>();
            deptService.getAllDepartment().ToList().ForEach(u =>
            {
                tbl_Department d = deptService.getDeptById(u.Id);
                Departments dep = new Departments
                {
                    ID = d.Id,
                    Department = d.Department
                };
                depList.Add(dep);
            }) ;
            depList.Insert(0, new Departments { ID = 0, Department = "Please select" });
            ViewBag.DepList = depList;
        }
        public IActionResult Details(int id)
        {            
            tbl_students ob=studentService.GetStudentById(id);
            Student s = new Student
            {
                ID = ob.Id,
                Name = ob.Name,
                Fname = ob.Fname,
                Email = ob.Email,
                Mobile = ob.Mobile,
                DepID = ob.DepID,
                Description = ob.Description
            };
            tbl_Department dep = deptService.getDeptById(s.DepID); 
            ob.Department = dep.Department;
            return View(ob);
        }
        public IActionResult Delete(int id)
        {
            try
            {
                studentService.RemoveStudent(id);
                return RedirectToAction("StudentList");
            }
            catch (Exception)
            {
                return RedirectToAction("StudentList");
            }
        }
    }
}
