using ATS.Models;
using ATS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Service
{
    public class DepartmentService : IDepartment
    {
        private readonly IRepository<tbl_Department> DeptRepository;
        public DepartmentService(IRepository<tbl_Department> _DeptRepository)
        {
            DeptRepository = _DeptRepository;
        }
        public IEnumerable<tbl_Department> getAllDepartment()
        {
            return DeptRepository.GetAll();
        }

        public tbl_Department getDeptById(int id)
        {
            return DeptRepository.Get(id);
        }

        public void InsertDept(tbl_Department ob)
        {
            DeptRepository.Insert(ob);
        }
    }
}
