using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowerCase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "~!@#$%^&*_+";

            Console.Write("Enter a password:  ");

            string password = Console.ReadLine();
            Console.WriteLine(password);

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, upperCase))  
            {
                score++;
            }
            if (Tools.Contains(password, lowerCase)) 
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
                case 4:
                case 5:
                    Console.WriteLine("Wow, you're password is extremely strong!!!!!!");
                    break;
                case 3:
                    Console.WriteLine("The password is strong, you could do better though!");
                    break;
                case 2:
                    Console.WriteLine("Ehhhh, you're password is medium");
                    break;
                case 1:
                    Console.WriteLine("Ooof, you're password is weak!");
                    break;
                default:
                    Console.WriteLine("The password doesn't meet any of our requirements, try again!");
                    break;


                    
            }
            Console.ReadKey();

        }
    }
}
