using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudMvc.Models;

namespace CrudMvc.Data
{
    public class CrudMvcContext : DbContext
    {
        public CrudMvcContext (DbContextOptions<CrudMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CrudMvc.Models.Department> Department { get; set; }

        public DbSet<CrudMvc.Models.Seller> Seller { get; set; }

        public DbSet<CrudMvc.Models.SalesRecord> SalesRecord { get; set; }
    }
}
