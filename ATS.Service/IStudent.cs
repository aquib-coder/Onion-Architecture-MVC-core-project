using ATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Service
{
    public interface IStudent
    {
        IEnumerable<Models.tbl_students> GetStudents();
        void RemoveStudent(long id);
        void UpdateStudent(Models.tbl_students s);
        void InsertStudent(Models.tbl_students s);
        Models.tbl_students GetStudentById(long id);
    }
}
