using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanavuAdmin.Database;

namespace PanavuAdmin.Logic
{
    internal class AdminLogic
    {
        AdminDB adminDB = new AdminDB();
        public bool GetAdmin(String email, String password)
        {
            if(adminDB.GetAdmin(email, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
