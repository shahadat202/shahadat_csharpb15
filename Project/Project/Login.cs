using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Login
    {
        private string CorrectUsername { get; set; }
        private string CorrectPassword { get; set;}

        public Login(string correctUsername, string correctPassword)
        {
            CorrectUsername = correctUsername;
            CorrectPassword = correctPassword;
        }
        public bool Authenticate(string enterUsername, string enterPassword)
        {
            return (enterUsername == CorrectUsername && enterPassword == CorrectPassword);  
        }
        public void ChangePassword(string newPassword)
        {
            CorrectPassword = newPassword;
            Console.WriteLine("\nPasswor changed successfully!\n");
        }
    }
}
