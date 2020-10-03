using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private  readonly ICommanderRepo _repo;
        public CommandsController(ICommanderRepo repo){
            _repo =  repo;
        }
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repo.GetAppCommands();
            return Ok(commandItems);
        }
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repo.GetCommandById(id);
            return Ok(commandItem);
        }

    }
}