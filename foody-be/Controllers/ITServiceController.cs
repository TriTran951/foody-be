using foody_be.Services;
using Microsoft.AspNetCore.Mvc;

namespace foody_be.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ITServiceController : Controller
    {
        private readonly ITService _iTService;
        public ITServiceController(ITService iTService)
        {
            _iTService = iTService;
        }
        [HttpPost]
        [Route("ingredient/addfromexcel")]
        public IActionResult addIngredientFromExcel(IFormFile file)
        {
            var ingredients = _iTService.addIngredientFromExcel(file);
            return Created();
        }
        [HttpPost]
        [Route("recipe/addfromexcel")]
        public IActionResult addRecipeFromExcel(IFormFile file)
        {
            return Created();
        }
    }
}
