using FiveToSeven_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;
        public OddOrEvenController (OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices = oddOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven/{num}")]
        public string OddOrEven(int num)
        {
            return _oddOrEvenServices.OddOrEven(num);
        }
    }
}