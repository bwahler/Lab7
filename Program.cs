using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Lab_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userName = NameValidation();
            string emailAddress = EmailValidation();
            string phoneNumber = PhoneValidation();
            string dateStamp = DateValidation();
        }

        public static string NameValidation()
        {
            //input
            Console.WriteLine("Please enter a valid name?");
            string userName = Console.ReadLine();

            //processing

            if (Regex.IsMatch(userName, @"[A-Z][A-z]{1,30}")==true)
            {
                Console.WriteLine("This is a valid name");
                userName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is not a valid name");
            }
            //output
            return userName;
        }
        public static string EmailValidation()
        {
            //input
            Console.WriteLine("Please enter a valid email address");
            string emailAddress = Console.ReadLine();


            //processing

            if (Regex.IsMatch(emailAddress, @"[A-z0-9]{5,30}@[A-z0-9]{1,10}.[A-z0-9]{1,3}")==true)
            {
                Console.WriteLine("This is a valid Email");
                emailAddress = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is not a valid email address");
            }
            //output
            return emailAddress;
        }
        public static string PhoneValidation()
        {
            //input
            Console.WriteLine("Please enter a valid phone number");
            string phoneNumber = Console.ReadLine();

            //processing

            if (Regex.IsMatch(phoneNumber, @"[0-9]{3}-[0-9]{3}-[0-9]{4}")==true)
            {
                Console.WriteLine("This is a valid phone number");
                phoneNumber = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This not a valid phone number");
            }
            //output
            return phoneNumber;
        }
        public static string DateValidation()
        {
            //input
            Console.WriteLine("Please enter a valid date");
            string dateStamp = Console.ReadLine();

            //processing

            if (Regex.IsMatch(dateStamp, @"(0?[1-9]|1[0-2])[\/](0?[1-9]|[12]\d|3[01])[\/](19|20)\d{2}$")== true)
            {
                Console.WriteLine("This is a valid date");
                dateStamp = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This is not a valid date");
            }
            return dateStamp;
        }
      }
    }