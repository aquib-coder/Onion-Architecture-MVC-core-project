using System;
using System.Collections.Generic;
using ATS.Models;
using ATS.Repositories;

namespace ATS.Service
{
    public class StudentService : IStudent
    {
        private readonly IRepository<tbl_students> StudentRepository;
        public StudentService(IRepository<tbl_students> _StudentRepository)
        {
            StudentRepository = _StudentRepository;
        }
        public Models.tbl_students GetStudentById(long id)
        {
            return StudentRepository.Get(id);
        }

        public IEnumerable<Models.tbl_students> GetStudents()
        {
            return StudentRepository.GetAll();
        }

        public void InsertStudent(Models.tbl_students s)
        {
            StudentRepository.Insert(s);
        }

        public void RemoveStudent(long id)
        {
            tbl_students s = GetStudentById(id);
            StudentRepository.Remove(s);
        }

        public void UpdateStudent(Models.tbl_students s)
        {
            StudentRepository.Update(s);
        }
    }
}
