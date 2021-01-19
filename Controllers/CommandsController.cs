using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace Commander.Controllers
{
    // this class implements a MVC Controller withow view support in this case
    // Controller => View support
    // ControllerBase => Not View suport

    // Route define how do you get the Resources and how do you get to the API Endpoints within your controller

    //api/commands
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        //In this fase, we create the constructor for the dependency injection
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;  
        }
        //private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // This clases define the Endpoints and we decorate it whit [HttpGet]
        // That define which actionresult respond to wich
        // GET api/commands/
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        // This annotation gives us a route to this action result // GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}