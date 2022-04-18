using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Models
{
    public class studentMap
    {
        public studentMap(EntityTypeBuilder<tbl_students> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            //entityBuilder.Property(t => t.Email).IsRequired();            
          //  entityBuilder.Property(t => t.Password).IsRequired();
           // entityBuilder.Property(t => t.Email).IsRequired();
           entityBuilder.HasOne(t => t.tbl_Department).WithOne(u=>u.tbl_students).HasForeignKey<tbl_Department>(x => x.Id);
        }
    }
}
