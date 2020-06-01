using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignColors;
using MaterialDesignThemes.Wpf;

namespace XAML2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public static ListeContact Liste { get; set; }
       // public static EntreeSortie Fichier { get; set; }
        public ListeContact Liste { get; set; } // à tester avec Owner dans le code
        public MainWindow(ListeContact registre)
        {
            InitializeComponent();
            Liste = registre;
            LstContacts.ItemsSource = Liste.Registre;
            if (Liste.Registre.Count > 0)
                btnModifier.IsEnabled = true;
            else
                btnModifier.IsEnabled = false;
        }
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();
            Liste = new ListeContact(contacts);
            EntreeSortie.Lecture(Liste);
            LstContacts.ItemsSource = Liste.Registre;
            if (Liste.Registre.Count > 0)
                btnModifier.IsEnabled = true;
            else
                btnModifier.IsEnabled = false;
        }
        /// <summary>
        /// Bouton pour quitter le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Bouton pour faire apparaître la fenêtre d'ajout d'un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, RoutedEventArgs e)
        {
            PageModif win2 = new PageModif(this)
            {
                Owner = this
            };
            win2.Show();
        }
        /// <summary>
        /// Bouton pour supprimer un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            bool? Result = new MBPerso("Êtes-vous sûr ?", MessageButtons.YesNo).ShowDialog();

        if (Result.Value)
            {
                Liste.SupprimerContact(Liste.Registre[LstContacts.SelectedIndex]);
                EntreeSortie.Ecriture(Liste);
            }
        }
        /// <summary>
        /// Bouton pour modifier un contact existant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, RoutedEventArgs e)
        {
            PageModif win2 = new PageModif(Liste.Registre[LstContacts.SelectedIndex], LstContacts.SelectedIndex, this)
            {
                Owner = this
            };
            win2.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            EntreeSortie.Ecriture(Liste);
        }

        private void Window_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Liste.Registre.Count > 0)
                btnModifier.IsEnabled = true;
            else
                btnModifier.IsEnabled = false;
        }

        private void Window_Closing(object sender, EventArgs e)
        {
            EntreeSortie.Ecriture(Liste);
        }
    }
}
