using ExperssionTreeInRunTimeDemo.Models;

namespace ExperssionTreeInRunTimeDemo.Services
{
    public interface IDepartmentServices
    {
        Task<IQueryable<Department>> Search(string coulmnname, string value);

    }
}
