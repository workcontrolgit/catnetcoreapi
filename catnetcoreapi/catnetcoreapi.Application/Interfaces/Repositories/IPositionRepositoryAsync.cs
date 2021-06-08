using catnetcoreapi.Application.Features.Positions.Queries.GetPositions;
using catnetcoreapi.Application.Parameters;
using catnetcoreapi.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace catnetcoreapi.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);

        Task<bool> SeedDataAsync(int rowCount);

        Task<(IEnumerable<Entity> data, RecordsCount recordsCount)> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}
