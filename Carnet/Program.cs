using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carnet
{
    public class Program
    {   /// <summary>
        /// 
        /// </summary>
        /// <param name="Carnet d'adresse"></param>
        ///
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            ListeContact registre = new ListeContact(contacts);
            EntreeSortie.Lecture(registre);
            Application.Run(new Form1(registre));
        }
    }
}
