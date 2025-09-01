using Backend.Controllers;
using Backend.UnitsOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.Entities;

namespace Orders.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriesController : GenericController<Category>
    {
        public CategoriesController(IGenericUnitOfWork<Category> unit) : base(unit)
        {
        }
    }
}