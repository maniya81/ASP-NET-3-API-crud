using System;
using System.Collections.Generic;
using System.Linq;
using CommandAPI.Data;
using Commander.Models;

namespace Commander.Data
{
    public class SqlCommandeRepo : ICommanderRepo
    {
        private readonly CommandContext _context;

        public SqlCommandeRepo(CommandContext context)
        {
            _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.CommandItems.Add(cmd);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.CommandItems.FirstOrDefault(P => P.Id ==id );
        }

        public bool SaveChanges()
        {
          return(_context.SaveChanges() >0);
        }
    }
}