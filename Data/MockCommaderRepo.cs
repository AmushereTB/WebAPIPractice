using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommaderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var allCommands = new List<Command>{
            new Command { Id = 0, HowTo = "Boil the water", Line = "Set Fire", Platform = "pan & wok" },
            new Command { Id = 1, HowTo = "Boil the Egg", Line = "Boil water", Platform = "pan & wok" },
            new Command { Id = 2, HowTo = "Frozen meat", Line = "open frigator", Platform = "ICE Box" },
            new Command { Id = 3, HowTo = "Watch TV", Line = "Start TV", Platform = "Living room & Wine" },
            };
            return allCommands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil the water", Line = "Set Fire", Platform = "pan & wok" };
        }
    }
}