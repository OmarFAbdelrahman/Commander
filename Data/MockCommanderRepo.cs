using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "HowTo1", Line = "Line1", Platform = "Platfrom1" },
                new Command { Id = 0, HowTo = "HowTo2", Line = "Line2", Platform = "Platfrom2" },
                new Command { Id = 0, HowTo = "HowTo3", Line = "Line3", Platform = "Platfrom3" }
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command { Id = 0, HowTo = "HowTo1", Line = "Line1", Platform = "Platfrom1" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
