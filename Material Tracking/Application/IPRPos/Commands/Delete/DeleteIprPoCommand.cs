using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace MT.Application.IPRPos.Commands.Delete
{
    public class DeleteIprPoCommand:IDeleteIprPoCommand
    {
        private readonly IDatabaseService _database;
        public DeleteIprPoCommand(IDatabaseService database)
        {
            _database = database;
        }
        public void Execute(int iprPoId)
        {
            //Delete File From Server 
            var iprPo = _database.ProjectIprPos.FirstOrDefault(f => f.ProjectIprPoId == iprPoId);
            if (iprPo != null) File.Delete(iprPo.Path);

            //Delete File From DB 
            _database.ProjectIprPos.Remove(iprPo);
            _database.Save();
        }
    }
}
