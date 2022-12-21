using Service.Service;
using Service.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Controllers
{
    public class LoginController
    {
        public static void CheckLogin(string username, string password)
        {
            IloginService loginservice = new LoginService();

            

            loginservice.Login(UserInfoService.CheckCredentials, username, password);
        }

        public static void CheckLoginInput()
        {
            Console.Write("Write username: ");
            string _username = Console.ReadLine();
            Console.Write("Write password: ");
            string _password = Console.ReadLine();

            CheckLogin(_username, _password);

        }
    }
}
