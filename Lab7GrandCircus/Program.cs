
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;// using regular expression system
using System.Threading.Tasks;

namespace FindInvalidInputWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //local variables
            string inputName;
            string inputEmail;
            string inputPhoneNumber;
            string inputDate;


            Console.WriteLine("Enter Your User Information:");
            /*** Looping through all the Functions  ***/
            
           do {

                // user name input
                Console.WriteLine("\nUserName:");

                Console.Write("\nPlease enter a valid Name:\t");

                inputName = Console.ReadLine();

                if (CheckName(inputName))
                {
                    Console.WriteLine("\n Valid Name.");
                }
                else
                {
                    Console.WriteLine("\n Invalid Name!");
                }




                // Email input
                Console.WriteLine("\nEmail:");

                Console.Write("\nEnter  a valid Email:\t");

                inputEmail = Console.ReadLine();

                if (CheckEmail(inputEmail))
                {
                    Console.WriteLine("\nEmail is valid!");
                }
                else
                {
                    Console.WriteLine("\nEmail is not valid!");
                }


                //phone number prompt
                Console.WriteLine("\n Phone Number:");

                Console.Write("\n Enter phone number:\t");

                inputPhoneNumber = Console.ReadLine();

                if (CheckPhoneNumber(inputPhoneNumber))
                {
                    Console.WriteLine("\n Phone Number is valid!");
                
                }     
                else
                {
                    Console.WriteLine("\n Phone Number is not valid!");
                }


                // date input
                Console.WriteLine("\n Date and Time :");

                Console.Write(" \n Please enter a valid date:\t");

                inputDate = Console.ReadLine();

                if (CheckDate(inputDate))
                {
                    Console.WriteLine("\n Date is valid !");
                }  
                else
                {
                    Console.WriteLine("\n Date is not valid!");
                }
                    
                if (!ToContinue())
                {
                    break;
                }

            } while (true);

            Console.WriteLine("\n See You Next Time !");

            Console.ReadKey();
        }

        /************ End  of Main ******************************************/



       /******** Method Functions **************************/

        // name validation
        public static bool CheckName(String name)
        {
            Regex NAME_PATTERN = new Regex(@"^([A-Z][a-z]{1,29})+$");

            return NAME_PATTERN.IsMatch(name);
        }


        // email validation
        public static bool CheckEmail(string email)
        {
            const string EMAIL_PATTERN = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

            if (email != null)
            {
                return Regex.IsMatch(email, EMAIL_PATTERN);
            }      
            else
            {
                return false;
            }
                
        }


        // phone number validation
        public static bool CheckPhoneNumber(string phone)
        {
            const string PHONE_PATTERN = @"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}";

            if (phone != null)
            {
                return Regex.IsMatch(phone, PHONE_PATTERN);
            }      
            else
            {
                return false;
            }
                
        }

        // date validation
        public static bool CheckDate(string date)
        {
            const string DATE_PATTERN = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$";

            if (date != null)
            {
                return Regex.IsMatch(date, DATE_PATTERN);
            }
               
            {
                return false;
            }
                
        }


        // continue yes or no
        private static bool ToContinue()
        {
            do//execute at least once
            {
                Console.WriteLine("\nContinue ? y/n");

                var toContinue= char.ToLower(Console.ReadKey().KeyChar);

               
                if(toContinue != 'y' && toContinue !='n')
                {
                      continue;
                }

                return toContinue == 'y';

            } while (true);
        }
    }
}