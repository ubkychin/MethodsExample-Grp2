using System;

namespace MethodsExample_Grp2
{
    class Program
    {
        static void Main(string[] args)
        {   
            LoginMenu();
        }

        public static string HelloName(string name) {
            string sentence = "Hello " + name;
            return sentence;
        }

        public static void LoginMenu() {
            System.Console.Write("username: ");
            string user = Console.ReadLine();

            System.Console.Write("password: ");
            string pass = Console.ReadLine();

            bool loginResult = Login(user, pass);
            if(loginResult) {
                System.Console.WriteLine("Successful Login");
            } else {
                System.Console.WriteLine("Unsuccessful Login");
            }

        }

        public static bool Login(string username, string password) {
            string validUsername = "Clive";
            string validPassword = "abc123";

            if (username == validUsername && password == validPassword) {
                return true;
            }

            return false;
        }
    }
}
