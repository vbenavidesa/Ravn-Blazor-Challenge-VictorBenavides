using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RavnChallenge.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PeopleController : ControllerBase
    {
        #region Constructor for dependency injection
        private readonly IConfiguration configuration;

        public PeopleController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        #endregion

        #region public async Task<IActionResult> GetPerson(long id)
        public async Task<IActionResult> GetPerson(long id)
        {
            return Ok();
        }
        #endregion

        #region public async Task<IActionResult> GetPeople()
        public async Task<IActionResult> GetPeople()
        {

            return Ok();
        }
        #endregion
    }
}
