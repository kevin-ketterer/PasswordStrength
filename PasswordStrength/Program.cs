using System;

namespace PasswordStrength
{
    class Program
    {
        private int minLength = 12;
        private string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string lowercase = "abcdefghijklmnopqrstuvwxyz";
        private string digits = "0123456789";
        private string specialChars = "~!@#$%^&*()_+|";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
