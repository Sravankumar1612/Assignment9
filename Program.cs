using System;
using System.Linq;

namespace Assignment9
{
    // Custom exception for validation errors
    public class CustomException:Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string username, email;
            string password;
            try
            {
                Console.WriteLine("Enter username ");
                username = Console.ReadLine();
                if (username.Length >= 6 )
                {
                    Console.WriteLine("Enter email");
                    email = Console.ReadLine();
                    if (!email.Contains("@") || !email.Contains("."))
                    {
                        throw new CustomException("Invalid email format.");
                    }
                    else
                    {
                        Console.WriteLine("Enter Password");
                        password = Console.ReadLine();
                        if (password.Length >= 8)
                        {
                            Console.WriteLine($"User registration success with username{username} and password {password}");
                        }
                        else
                        {
                            throw new CustomException("Invalid password (Password must be 8 characters or above)");
                        }
                    }
                }
                else
                {
                    throw new CustomException("Invalid username (Password must be  6 characters or above And Contains Only Alphabets)");
                }
            }
            catch (CustomException ce) { Console.WriteLine(ce); }
            catch (Exception e) { Console.WriteLine("Error : "+e.Message); }
            Console.ReadKey();
        }
    }
}
