using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo  : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
           var commands = new List<Command>
            {
                new Command{
                    Id=0, HowTo="How to genrate a migration", 
                    CommandLine="dotnet ef migrations add <Name of Migration>", 
                    Platform=".Net Core EF"},
                new Command{
                    Id=1, HowTo="Run Migrations", 
                    CommandLine="dotnet ef database update", 
                    Platform=".Net Core EF"}
            };

            return commands;
            
        }
        public Command GetCommandById(int id)
        {
            return new Command{
                Id=0, HowTo="How to genrate a migration", 
                CommandLine="dotnet ef migrations add <Name of Migration>", 
                Platform=".Net Core EF"};

        }
    }
}