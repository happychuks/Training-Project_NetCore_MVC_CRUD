using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace NetCore_MVC_CRUD.Models
{

    public class ApplicationDbContext:DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<EmployeeMVcClass> EmployeeMVCTable { get; set; }
        public DbSet<EmployeeSalaryScale> EmployeeSalaryList { get; set; }
    }
}
