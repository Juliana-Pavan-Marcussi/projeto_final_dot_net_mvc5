using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudMvc.Data;
using CrudMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudMvc.Services
{
    public class DepartmentService
    {

        private readonly CrudMvcContext _context;

        public DepartmentService(CrudMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
