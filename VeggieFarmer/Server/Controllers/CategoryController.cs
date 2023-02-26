using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VeggieFarmer.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Category>>>> GetCateories()
        {
            var result = await _categoryService.GetCategories();
            return Ok(result);
        }
    }
}
