using ExperssionTreeInRunTimeDemo.Context;
using ExperssionTreeInRunTimeDemo.Models;

namespace ExperssionTreeInRunTimeDemo.Services
{
    public class DepartmentServices :IDepartmentServices
    {
        private readonly DemoContext context;

        public DepartmentServices(DemoContext context)
        {
            this.context = context;
        }
        public async Task<IQueryable<Department>> Search(string coulmnname, string value)
        {
            var deptlist = context.departments.AsQueryable();
            var departments = deptlist.Search(coulmnname, value);
            return departments;
        }
    }
}
