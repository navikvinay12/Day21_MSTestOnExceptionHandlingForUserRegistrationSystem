using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationExceptionHandling
{
    public class UserDetails
    {
        public static string FirstName(string userInput)
        {
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Try again!Please keep 3 characters minimum and atleast 1 letter as capital.");
                }
            }
        }
        public static string LastName(string userInput)
        {
            string regexCondition = "^[A-Z]{1}[a-z]{2,}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Try again!Please keep 3 characters minimum and atleast 1 letter as capital.");
                }
            }
        }
        public static string EmailId(string userInput)
        {
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Entered Email ID is not in proper format .Please try again with something different.");
                }
            }
        }
        public static string MobileNumber(string userInput)
        {
            string regexCondition = "^[9]{1}[1]{1}[ ]{1}[1-9]{1}[0-9]{9}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Entered Mobile No is not in proper format.It shall be like 91 **********");
                }
            }
        }
        public static string PassMin8Char(string userInput)
        {
            string regexCondition = "^[a-zA-Z0-9]{8,}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Entered password doesn't meet the password policy.There must be atleast 8 characters");
                }
            }
        }
        public static string PassMin8CharAnd1UpperCase(string userInput)
        {
            string regexCondition = "^(?=.*[A-Z]).{1,}[a-zA-Z0-9]{7,}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Try Again !There must be atleast 8 characters including atleast 1 uppercase");
                }
            }
        }
        public static string UpperCase1AndNumeric1(string userInput)
        {
            string regexCondition = "^(?=.*[A-Z]).{1,}(?=.*[0-9]).{1,}[a-zA-Z0-9]{6,}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Try Again !There must be atleast 8 characters including atleast 1 uppercase and 1 Numeric");
                }
            }
        }
        public static string SpecialCharacter1(string userInput)
        {
            string regexCondition = "(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Try Again !There must be atleast 8 characters including only 1 special char and atleast 1 uppercase and 1 Numeric");
                }
            }
        }
        public static string EmailSample(string userInput)
        {
            string regexCondition = "^[a-z0-9]{1,}([._+-]{1}[a-z0-9]{1,}){0,1}[@]{1}[a-z0-9]{1,}[.]{1}[a-zA-Z]{2,3}([.]{1}[a-z]{2,3}){0,1}$";
            if (String.IsNullOrEmpty(userInput) == true)
            {
                throw new CustomExceptionInvalidInput("Input should not be empty or null");
            }
            else
            {
                if (Regex.IsMatch(userInput, regexCondition))
                {
                    return "Validated successfully!";
                }
                else
                {
                    throw new CustomExceptionInvalidInput("Entered Email ID is not in proper format .Please try again with something different.");
                }
            }
        }
    }
}
