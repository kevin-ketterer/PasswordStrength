using System;

namespace PasswordStrength
{
    class Program
    {
        static void Main(string[] args)
        {
            var minLength = 12;
            var score = 0;
            var uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var lowercase = "abcdefghijklmnopqrstuvwxyz";
            var digits = "0123456789";
            var specialChars = "~!@#$%^&*()_+|";

            Console.Write("Enter your password: ");
            var password = Console.ReadLine();

            if (password != null && password.Length >= minLength)
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            switch (score)
            {
                case 1: 
                    Console.Write("Your password is weak");
                    break;
                case 2:
                    Console.Write("Your password is medium");
                    break;
                case 3:
                    Console.Write("Your password is strong");
                    break;
                case 4:
                case 5:
                    Console.Write("Your password is extremely strong");
                    break;
                default:
                    break;
            }
        }
    }
}
