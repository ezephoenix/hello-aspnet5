using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Hello.Web.Controllers
{
    /// <summary>
    /// Greeting Controller
    /// </summary>
    [Route("api/[controller]")]
    public class GreetingController : Controller
    {
        /// <summary>
        /// Retrieve greeting!
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<string> Get()
        {
            return await Task.FromResult("Huzzah, world! It's ASP.NET 5!");
        }
    }
}