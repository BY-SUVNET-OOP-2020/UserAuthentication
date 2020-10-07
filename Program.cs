using System;

namespace LoginSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserAuthentication userAuthentication = new UserAuthentication();

            userAuthentication.AddUser("gustav", "password");
            userAuthentication.AddUser("jane", "drowssap");
            userAuthentication.AddUser("sivert", "pwd");
            userAuthentication.AddUser("gun", "1234");

            bool isValidUser = userAuthentication.TryValidateUser("gustav", "password");

            Console.WriteLine("User count: " + User.Count);
            Console.WriteLine("IsValidUser: " + isValidUser);
        }
    }
}