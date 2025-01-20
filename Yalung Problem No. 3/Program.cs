using System.Text.RegularExpressions;

namespace Yalung_Problem_No._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();                       //Prompt for password

            if (StrongPassword(password))
            {
                Console.WriteLine("Your password is strong!");          //Prompt if password is strong
            }
            else
            {
                Console.WriteLine("Your password is weak!");            //Prompts if password is weak
                Console.WriteLine("Your password must contain an uppercase and lowercase character.");
                Console.WriteLine("Your password must also contain a single digit or a special character.");
            }
        }

        static bool StrongPassword(string password)
        {
            if (password.Length < 8) return false; 
            if (!Regex.IsMatch(password, @"[A-Z]")) return false;       // Checks if meron nakaCaps
            if (!Regex.IsMatch(password, @"[a-z]")) return false;       // Checks for small letters
            if (!Regex.IsMatch(password, @"[\d]")) return false;        // Checks for numbers
            if (!Regex.IsMatch(password, @"[\W_]")) return false;       // Checks for special characters

            return true;                                                // Password contains all criteria
        }
    }
}
