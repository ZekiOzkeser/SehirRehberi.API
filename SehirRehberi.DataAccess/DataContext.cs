using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using SehirRehberi.Entities;

namespace SehirRehberi.DataAccess
{
   public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=ZEK\\SQLEXPRESS01; Database=SehirRehberi; Trusted_Connection=True");
        }


        //public  DbSet<Value> Values { get; set; }
    }
}
