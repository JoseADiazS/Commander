using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    // Esta interfaz va a poseer todos los metodos crud que utilizara la app 
	public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();

        Command GetCommandById(int id); 
    }
}