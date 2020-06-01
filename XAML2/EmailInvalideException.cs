using System;
using System.Runtime.Serialization;

namespace XAML2
{
    internal class EmailInvalideException : Exception
    {
        public string EmailInvalide { get;set;}
        public EmailInvalideException()
        {

        }
        public EmailInvalideException(string message) : base(message)
        {
            
        }
        public EmailInvalideException(string message, string email) : this(message)
        {
            EmailInvalide = email;
        }
    }
}