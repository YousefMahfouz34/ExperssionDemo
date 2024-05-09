using ExperssionTreeInRunTimeDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExperssionTreeInRunTimeDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpolyeeController : ControllerBase
    {
        private readonly IEmpolyeeServices empolyeeServices;

        public EmpolyeeController( IEmpolyeeServices empolyeeServices)
        {
            this.empolyeeServices = empolyeeServices;
        }
        [HttpGet]
         public async Task<IActionResult>search(string column ,string value)
        {
            try
            {
                var res = await empolyeeServices.Search(column, value);
                return Ok(res);
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);  
            }
        }
    }
}
