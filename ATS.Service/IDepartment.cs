using ATS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Service
{
   public interface IDepartment
    {
        IEnumerable<tbl_Department> getAllDepartment();
        tbl_Department getDeptById(int id);
        void InsertDept(tbl_Department ob);
    }
}
