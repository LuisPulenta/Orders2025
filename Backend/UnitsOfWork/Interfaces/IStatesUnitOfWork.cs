using Shared.DTOs;
using Shared.Entities;
using Shared.Responses;

namespace Backend.UnitsOfWork.Interfaces;

public interface IStatesUnitOfWork
{
    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<State>>> GetAsync();

    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}