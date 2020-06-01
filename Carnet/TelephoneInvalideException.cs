using System;
using System.Runtime.Serialization;

namespace Carnet
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