using EmployeeWebApp.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeWebApp.Models.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department> GetDepartment(int departmentId)
        {
            return await _context.Departments.FirstOrDefaultAsync(e => e.DepartmentId == departmentId);
        }


    }
}
