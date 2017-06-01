using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application.Admins.Commands.Factory
{
    public class AdminFactory:IAdminFactory
    {
        public Admin Create(string name, string password, string mail, int adminid)
        {
            var admin = new Admin();
            admin.AdminId = adminid;
            admin.Email = mail;
            admin.Password = password;
            admin.Name = name;
            return admin;
        }
    }
}
