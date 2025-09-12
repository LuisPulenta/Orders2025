using Backend.Repositories.Interfaces;
using Backend.UnitsOfWork.Implementations;
using Shared.DTOs;
using Shared.Entities;
using Shared.Responses;

namespace Backend.UnitsOfWork.Interfaces;

public class CitiesUnitOfWork : GenericUnitOfWork<City>, ICitiesUnitOfWork
{
    private readonly ICitiesRepository _citiesRepository;

    public CitiesUnitOfWork(IGenericRepository<City> repository, ICitiesRepository citiesRepository) : base(repository)
    {
        _citiesRepository = citiesRepository;
    }

    public override async Task<ActionResponse<IEnumerable<City>>> GetAsync(PaginationDTO pagination) => await _citiesRepository.GetAsync(pagination);

    public override async Task<ActionResponse<int>> GetTotalRecordsAsync(PaginationDTO pagination) => await _citiesRepository.GetTotalRecordsAsync(pagination);
}