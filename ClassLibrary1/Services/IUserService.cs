using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Services
{
    public interface IUserService
    {
        int AddUser(string Username, string First, string Last);
        string GetUser();
    }
}
