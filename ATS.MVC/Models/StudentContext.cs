//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebApplication2.Models
//{
//    public class StudentContext:DbContext
//    {
//        public StudentContext(DbContextOptions<StudentContext> options):base(options)
//        {

//        }
//        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        //{
//        //    optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB ;Initial Catalog=mvcCrudDb;Integrated Security=SSPI" );
//        //}

//        public DbSet<Student> tbl_student { get; set; }
//        public DbSet<Departments> tbl_Departments { get; set; }
//        public DbSet<Student> StudentList { get; set; }
       
//    }
//}
