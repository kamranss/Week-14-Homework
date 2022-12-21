using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service.Interfaces
{
    public interface IloginService
    {
        void Login(Func<string, string, bool> function, string username, string password);
    }
}
