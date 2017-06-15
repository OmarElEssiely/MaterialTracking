using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.IPRs.Commands.Delete
{
    public class DeleteIprCommand:IDeleteIprCommand
    {
        private readonly IDatabaseService _database;
        public DeleteIprCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int iprId)
        {
            //Delete File From Server 
            var ipr = _database.ProjectIprs.FirstOrDefault(f => f.ProjectIprId == iprId);
            if (ipr != null) File.Delete(ipr.Path);

            //Delete File From DB 
            _database.ProjectIprs.Remove(ipr);
            _database.Save();
        }
    }
}
