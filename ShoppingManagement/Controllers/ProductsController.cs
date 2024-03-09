using Microsoft.AspNetCore.Mvc;

namespace ShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return ["value1", "value2"];
        }
    }
}
