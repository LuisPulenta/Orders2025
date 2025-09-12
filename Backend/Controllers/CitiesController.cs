using Backend.UnitsOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Entities;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CitiesController : GenericController<City>
{
    public CitiesController(IGenericUnitOfWork<City> unitOfWork) : base(unitOfWork)
    {
    }
}