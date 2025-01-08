using FiveToSeven_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericServices _reverseItAlphanumericServices;
        public ReverseItAlphanumericController (ReverseItAlphanumericServices reverseItAlphanumericServices)
        {
            _reverseItAlphanumericServices = reverseItAlphanumericServices;
        }

        [HttpGet]
        [Route("ReverseItAlpha/{input}")]
        public string ReverseItAlpha (string input)
        {
            return _reverseItAlphanumericServices.ReverseItAlpha(input);
        }
    }
}