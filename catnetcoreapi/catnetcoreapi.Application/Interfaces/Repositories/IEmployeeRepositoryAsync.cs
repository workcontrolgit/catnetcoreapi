using catnetcoreapi.Application.Features.Employees.Queries.GetEmployees;
using catnetcoreapi.Application.Parameters;
using catnetcoreapi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace catnetcoreapi.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}
