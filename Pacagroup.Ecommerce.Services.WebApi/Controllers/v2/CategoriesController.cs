namespace Pacagroup.Ecommerce.Services.WebApi.Controllers.v2
{

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.RateLimiting;
    using Pacagroup.Ecommerce.Application.DTO;
    using Pacagroup.Ecommerce.Application.Interface.UseCases;
    using Pacagroup.Ecommerce.Transversal.Common;
    using Swashbuckle.AspNetCore.Annotations;


    [Authorize]
    [EnableRateLimiting("fixedWindow")]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("2.0")]
    [SwaggerTag("Get categories of products")]
    public class CategoriesController : Controller
    {
        private readonly ICategoriesApplication _categoriesApplication;

        public CategoriesController(ICategoriesApplication categoriesApplication)
        {
            _categoriesApplication = categoriesApplication;
        }

        [HttpGet("GetAll")]
        [SwaggerOperation(Summary = "Get Categories", 
                          Description = "This Endpoint will return all categories", 
                          OperationId = "GeTAll", 
                          Tags = new string[] { "GetAll"})]
        [SwaggerResponse(200, "List of categories", typeof(Response<IEnumerable<CategoryDto>>))]
        [SwaggerResponse(404, "Not found categories")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoriesApplication.GetAll();
            if(response.IsSuccess) 
            {
               return Ok(response);
            }
            return BadRequest(response);
        }
    }
}
