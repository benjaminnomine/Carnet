using System;
using System.Runtime.Serialization;

namespace XAML2
{
    internal class TelephoneInvalideException : Exception
    {
        public string NoTel;

        public TelephoneInvalideException()
        {
        }

        public TelephoneInvalideException(string message) : base(message)
        {
        }

        public TelephoneInvalideException(string message, string noTel) : this(message)
        {
            NoTel = noTel;
        }
    }
}