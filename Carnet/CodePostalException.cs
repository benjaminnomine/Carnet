using System;
using System.Runtime.Serialization;

namespace Carnet
{
    internal class CodePostalException : Exception
    {

        public string MauvaisCP { get; set; }
        public CodePostalException()
        {

        }

        public CodePostalException(string message) : base(message)
        {
            
        }
        public CodePostalException(string message, string codepostal) : base(message)
        {
            MauvaisCP = codepostal;
        }
    }
}