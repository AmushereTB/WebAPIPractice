using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly MockCommaderRepo _repository = new MockCommaderRepo();

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var getAllCommands = _repository.GetAppCommands();
            return Ok(getAllCommands);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var getCommandById = _repository.GetCommandById(id);
            return Ok(getCommandById);
        }
    }
}