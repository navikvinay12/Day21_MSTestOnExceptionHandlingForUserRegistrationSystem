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
            try
            {
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
                        throw new CustomExceptionInvalidInput("Input should be in proper format");
                    }
                }
            }
            catch (CustomExceptionInvalidInput ex)
            {
                return ex.Message;
            }
        }
    }
}
