using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;
using System.Text.RegularExpressions;

namespace assignment1
{


    public class Program
    {
        public static void Main(string[] args)
        {
            string s;// ------------Taking a string as input for checking
            Console.WriteLine(" Enter your Email Id");
            s = Console.ReadLine();///------------reading from input console
            bool i = IsValidEmail(s);///calling Emailchecking function which returns a bool type (true or false)
            if (i)// ------------Checking whether valid
                Console.WriteLine("valid email");
            else
                Console.WriteLine("Invalid email has enetered");

            Console.ReadLine();
        }
        public static bool IsValidEmail(string email)////collecting forlmal argument in "email" 
        {
            if (string.IsNullOrWhiteSpace(email))///checkin null or only blank spaces in string
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));//regular domain name is defined in 2nd argument

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

        }

    }
    }



