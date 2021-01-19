using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    // Class that implement the Interface
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Plataform = "Kettle & Pan" },
                new Command{Id = 1, HowTo = "Cut Bread", Line = "Get a knife", Plataform = "Knife & Choping" },
                new Command {Id = 2, HowTo = "Make cup of tea ", Line = "Boil water", Plataform = "Kettle & Pan" },
            };
            return commands;
        }


        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Plataform = "Kettle & Pan" };
            //}
        }
    }
}