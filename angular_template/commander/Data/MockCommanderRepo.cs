using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=1, HowTo="Cut bread", Line="Get knife, slice", Platform="Counter"},
                new Command{Id=2, HowTo="Make toase", Line="toast bread, apply butter", Platform="Refriderator"},
                new Command{Id=3, HowTo="Eat Breakfeast", Line="Insert food into mouth hole, manually digest until bolus, swallow til completion", Platform="Table"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil water, add egg, remove after 15 min", Platform = "kettle and pan" };
        }
    }
}