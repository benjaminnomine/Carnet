using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAML2
{
    class ContactDejaPresentException : Exception
    {
        public int Index { get; internal set; }
        public Contact Contact { get; internal set; }

        public ContactDejaPresentException()
        {
            
        }
        public ContactDejaPresentException(string message, Contact contact, int index) : base(message)
        {
            Index = index;
            Contact = contact;
        }
    }
}
