using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Services.Contracts;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController:ControllerBase
    {
        private readonly IServiceManager _manager;

        public CategoriesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            return Ok(await _manager
                .CategoryService
                .GetAllCategoriesAsync(false));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCategoryAsync([FromRoute]int id)
        {
            return Ok(await _manager
                .CategoryService
                .GetOneCategoryByIdAsync(id,false));
        }
    }
}
