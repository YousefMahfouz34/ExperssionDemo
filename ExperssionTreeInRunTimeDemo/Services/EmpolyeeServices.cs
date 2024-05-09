using ExperssionTreeInRunTimeDemo.Context;
using ExperssionTreeInRunTimeDemo.Models;

namespace ExperssionTreeInRunTimeDemo.Services
{
    public class EmpolyeeServices : IEmpolyeeServices
    {
        private readonly DemoContext context;

        public EmpolyeeServices(DemoContext context)
        {
            this.context = context;
        }
        public async Task<IQueryable<Empolyee>> Search(string coulmnname, string value)
        {
            //List<IQueryable<Empolyee>> EmpList = new List<IQueryable<Empolyee>>();
           var EmpList= context.empolyees.AsQueryable();
           var emps=EmpList.Search(coulmnname, value);
            return emps;
        }
    }
}
