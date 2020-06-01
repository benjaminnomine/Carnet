using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace XAML2
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            App app = new App();
            app.InitializeComponent();
            app.Run();
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            ListeContact registre = new ListeContact(contacts);
            EntreeSortie.Lecture(registre);
            MainWindow window = new MainWindow(registre);
            window.Show();
            //window.ShowDialog(); //à tester
        }
    }
}
