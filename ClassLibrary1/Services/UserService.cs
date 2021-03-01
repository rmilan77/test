using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        public int AddUser(string Username, string First, string Last)
        {
            Console.WriteLine("this is from service, adding " + Username);
            return 1;
        }

        public string GetUser()
        {
            return "milan";
        }
    }
}
