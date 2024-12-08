using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Domain.Model;
using UnitOfWork.Infrastructure.Interfaces;

namespace UnitOfWork.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("get")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategory()
        {
            try
            {
                var result = await _unitOfWork.CategoryRepository.ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {

                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            try
            {
                var result = await _unitOfWork.CategoryRepository.RegisterAsync(category);
                await _unitOfWork.CompleteAsync();
                return Ok(result);
            }
            catch (BadHttpRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
