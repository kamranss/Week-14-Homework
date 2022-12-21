using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    internal class UserInfoService
    {
        public static User GetUser()
        {
            User user = new()
            {
                Username = "Kamran",
                Password = "alpina678"
            };
            return user;
        }
        public static bool CheckCredentials(string username, string password)
        {
            return username == UserInfoService.GetUser().Username && password == UserInfoService.GetUser().Password;
        }
       
    }
}
