using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConAssignment_9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName, email, password;

            try
            {
                Console.WriteLine("Enter userName");
                userName = Console.ReadLine();               
                Console.WriteLine("Enter email");
                email = Console.ReadLine();
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    throw new ValidationException("All fields are required.");
                }
                if (userName.Length < 6)
                {
                    throw new ValidationException("User name must have atleast 6 characters ");
                }
                else if (password.Length < 8)
                {
                    throw new ValidationException("Password must have atleast 8 characters");
                }
                else
                {
                    Console.WriteLine("Login Succesfully");
                    Console.WriteLine($"Given name : {userName}\t & email is :{email}\t &Password is : {password} ");

                }

            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Validation Error " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            finally
            {
                Console.WriteLine("End of the Program");
                Console.ReadKey();
            }
        }
    }
}


