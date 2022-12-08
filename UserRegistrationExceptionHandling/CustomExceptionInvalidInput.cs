using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationExceptionHandling
{
    public class CustomExceptionInvalidInput : Exception
    {
        public CustomExceptionInvalidInput(string? message) : base(message)
        {
        }
    }
}
