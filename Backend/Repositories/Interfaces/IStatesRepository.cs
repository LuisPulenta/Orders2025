using Shared.DTOs;
using Shared.Entities;
using Shared.Responses;

namespace Backend.Repositories.Interfaces;

public interface IStatesRepository
{
    Task<ActionResponse<State>> GetAsync(int id);

    Task<ActionResponse<IEnumerable<State>>> GetAsync();

    Task<ActionResponse<IEnumerable<State>>> GetAsync(PaginationDTO pagination);

    Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination);
}