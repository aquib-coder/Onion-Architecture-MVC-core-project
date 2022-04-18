using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models
{
    public class departmentMap
    {
        public departmentMap(EntityTypeBuilder<tbl_Department> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
           // entityBuilder.Property(t => t.Department).IsRequired();
            //  entityBuilder.Property(t => t.Password).IsRequired();
            //entityBuilder.Property(t => t.Email).IsRequired();
           // entityBuilder.HasOne(t => t.tbl).WithOne(u => u.User).HasForeignKey<UserProfile>(x => x.Id);
        }
    }
}
