using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._10_1.Models
{
    public static class AuthModel
    {
        const string ValidUsername = "admin";
        const string ValidPassword = "12345";

        public static bool Authenticate(string username, string password)
        {
            var result = username == ValidUsername && password == ValidPassword ? true : false;

            return result;
        }
    }
}
