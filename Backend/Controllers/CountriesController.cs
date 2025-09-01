using Backend.UnitsOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Entities;

namespace Backend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CountriesController : GenericController<Country>
{
    public CountriesController(IGenericUnitOfWork<Country> unit) : base(unit)
    {
    }
}