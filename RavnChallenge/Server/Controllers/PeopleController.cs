using Microsoft.AspNetCore.Mvc;
using RavnChallenge.Server.Interfaces;
using RavnChallenge.Shared.Dtos;
using System.Threading.Tasks;

namespace RavnChallenge.Server.Controllers
{
    [ApiController]
    [Route("/people")]
    public class PeopleController : ControllerBase
    {
        #region Constructor for dependency injection
        private readonly IRepository repository;
        public PeopleController(IRepository repository)
        {
            this.repository = repository;
        }
        #endregion

        #region public IActionResult GetPerson(long id)
        [HttpGet("{id}")]
        public IActionResult GetPerson(string id)
        {
            var result = repository.GetSingle<PersonDto>("people/", id);
            return Ok(result);
        }
        #endregion

        #region public IActionResult GetPeople()
        [HttpGet]
        public IActionResult GetPeople(string pageNumber = "1")
        {
            var result = repository.GetAllPaginated<PersonDto>("people/", pageNumber);
            return Ok(result);
        }
        #endregion
    }
}
