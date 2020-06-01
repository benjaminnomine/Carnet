using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace XAML2
{
    /// <summary>
    /// Logique d'interaction pour PageModif.xaml
    /// </summary>
    public partial class PageModif : Window
    {
        public Contact ContactAModif;
        public int Index;
        public bool Modification;
        public MainWindow mainWindow;

        public PageModif(Contact contact, int index, MainWindow window)
        {
            InitializeComponent();
            ContactAModif = contact;
            Index = index;
            NomBox.Text = ContactAModif.Nom;
            PrenomBox.Text = ContactAModif.Prenom;
            NoTelBox.Text = ContactAModif.NoTel;
            AdresseBox.Text = ContactAModif.Adresse;
            CPBox.Text = ContactAModif.Codepostal;
            VilleBox.Text = ContactAModif.Ville;
            EmailBox.Text = ContactAModif.Email;
            ProvinceComboBox.Text = ContactAModif.Province;
            Modification = true;
            //mainWindow = (MainWindow)Owner;
            mainWindow = window;
        }
        public PageModif(MainWindow window)
        {
            InitializeComponent();
            Modification = false;
            mainWindow = window;
        }
        private void BtnSauver_Click(object sender, RoutedEventArgs e)
        {
            if (Modification)
            {
                try
                {
                    mainWindow.Liste.SupprimerContact(Index);
                    mainWindow.Liste.InsererContact(new Contact(NomBox.Text, PrenomBox.Text, AdresseBox.Text, CPBox.Text, VilleBox.Text, NoTelBox.Text, EmailBox.Text, ProvinceComboBox.Text),Index);
                    EntreeSortie.Ecriture(mainWindow.Liste);
                    this.Close();
                }
                catch (EmailInvalideException exception)
                {
                    EmailBox.Focus();
                    MBPerso mBPerso = new MBPerso(exception.Message, MessageButtons.Ok);
                }
                catch (CodePostalException exception)
                {
                    CPBox.Focus();
                    MBPerso mBPerso = new MBPerso(exception.Message, MessageButtons.Ok);
                }
                catch (TelephoneInvalideException exception)
                {
                    NoTelBox.Focus();
                    MBPerso mBPerso = new MBPerso(exception.Message, MessageButtons.Ok);
                }
            }
            else
            {
                try
                {
                    mainWindow.Liste.AjouterContact(new Contact(NomBox.Text, PrenomBox.Text, AdresseBox.Text, CPBox.Text, VilleBox.Text, NoTelBox.Text, EmailBox.Text, ProvinceComboBox.Text));
                    EntreeSortie.Ecriture(mainWindow.Liste);
                    this.Close();
                }
                catch (EmailInvalideException exception)
                {
                    EmailBox.Focus();
                    MBPerso mBPerso = new MBPerso(exception.Message, MessageButtons.Ok);
                }
                catch (CodePostalException exception)
                {
                    CPBox.Focus();
                    MBPerso mBPerso = new MBPerso(exception.Message, MessageButtons.Ok);
                }
                catch (TelephoneInvalideException exception)
                {
                    NoTelBox.Focus();
                    MBPerso mBPerso = new MBPerso(exception.Message, MessageButtons.Ok);
                }
                catch (ContactDejaPresentException exception)
                {
                    bool? result = new MBPerso(exception.Message, MessageButtons.YesNo).ShowDialog();
                    if (result.Value)
                    {
                        mainWindow.Liste.SupprimerContact(exception.Contact);
                        mainWindow.Liste.InsererContact(new Contact(NomBox.Text, PrenomBox.Text, AdresseBox.Text, CPBox.Text, VilleBox.Text, NoTelBox.Text, EmailBox.Text, ProvinceComboBox.Text), exception.Index);
                        EntreeSortie.Ecriture(mainWindow.Liste);
                    }
                    else
                    {
                        NomBox.Focus();
                    }
                }
            }
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
