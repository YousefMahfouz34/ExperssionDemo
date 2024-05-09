using ExperssionTreeInRunTimeDemo.Models;

namespace ExperssionTreeInRunTimeDemo.Services
{
    public interface IEmpolyeeServices
    {
        Task<IQueryable<Empolyee>> Search(string coulmnname, string value);
    }
}
