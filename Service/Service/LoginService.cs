using Service.Helpers;
using Service.Helpers.Exceptions;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class LoginService : IloginService
    {
        
        public  void Login(Func<string, string, bool> function, string username, string password)
        {
            try
            {
                if (function(username, password))
                {
                    Console.WriteLine(LoginMessage.LoginSuccess);
                }
                else
                {
                    throw new LoginException(LoginMessage.LoginUnSuccess);
                }
            }
            catch (LoginException message)
            {

                Console.WriteLine(message.Message);
            }
           
        }
       
        
    }
}
