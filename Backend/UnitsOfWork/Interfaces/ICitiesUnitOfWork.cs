using Shared.DTOs;
using Shared.Entities;
using Shared.Responses;

namespace Backend.UnitsOfWork.Interfaces;

public interface ICitiesUnitOfWork
{
    Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}