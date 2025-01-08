using FiveToSeven_Endpoints.Services;
using Microsoft.AspNetCore.Mvc;

namespace FiveToSeven_Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;
        public MadLibController (MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("MadLib/{animal}/{name}/{food}/{age}")]
        public string MadLib(string animal, string name, string food, int age)
        {
            return _madLibServices.MadLib(animal, name, food, age);
        }
    }
}