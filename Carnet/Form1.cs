using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;


namespace Carnet
{
    delegate void GererContact(Contact contact);
    public partial class Form1 : Form
    {
        public static ListeContact Liste { get; set; }
        public bool Modification { get; set; }

        // constructeur qui récupère les lectures du main
        public Form1(ListeContact liste)
        {
            InitializeComponent();
            Liste = liste;
            RafraichirListe();
        }
        // Rafraichir la listbox en changeant la DataSource puis en la remettant
        // listeContact.Refresh() ne fonctionne pas
        public void RafraichirListe()
        {
            listeContact.DataSource = null;
            listeContact.DataSource = Liste.Registre;
            listeContact.DisplayMember = "NomComplet";
            listeContact.ValueMember = "Nom";
            listeContact.SelectedValueChanged += new EventHandler(listeContact_SelectedIndexChanged);
            listeContact.ClearSelected();
        }
        // simple bouton Quitter
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // lors du clic sur un élément de la liste (2 méthodes avec 2 événements)
        private void listeContact_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeContact.SelectedIndex != -1)
            {
                boxProvince.SelectedItem = null;
                RemplirChamps(Liste.Registre[listeContact.SelectedIndex]);
                ActiverBouton(true);
            }
            else if (listeContact.SelectedIndex <= -1)
            {
                listeContact.ClearSelected();
                ActiverBouton(false);
            }
        }
        private void listeContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listeContact.SelectedIndex != -1)
            {
                boxProvince.SelectedItem = null;
                RemplirChamps(Liste.Registre[listeContact.SelectedIndex]);
                ActiverBouton(true);
            }
            else if (listeContact.SelectedIndex <= -1)
            {
                listeContact.ClearSelected();
                ActiverBouton(false);
            }
        }
        // ajouter un contact donc rendre les champs Readonly = false et enlever toute sélection de la listbox
        private void btnAjout_Click(object sender, EventArgs e)
        {
            ViderChamps();
            ActiverChamps(true);
            listeContact.ClearSelected();
            ActiverBouton(true);
        }
        // vider les textbox de contenu
        private void ViderChamps()
        {
            boxNom.Text = "";
            boxAdresse.Text = "";
            boxPrenom.Text = "";
            boxEmail.Text = "";
            boxVille.Text = "";
            boxCP.Text = "";
            boxTel.Text = "";
            boxProvince.Text = "";
            boxProvince.SelectedItem = null;
        }
        // Change l'état des textbox de true à false ou l'inverse
        private void ActiverChamps(bool activer)
        {
            boxNom.ReadOnly = !activer;
            boxAdresse.ReadOnly = !activer;
            boxPrenom.ReadOnly = !activer;
            boxEmail.ReadOnly = !activer;
            boxVille.ReadOnly = !activer;
            boxCP.ReadOnly = !activer;
            boxTel.ReadOnly = !activer;
        }
        // Remplir les textbox avec les info du contact
        private void RemplirChamps(Contact contact)
        {
            boxNom.Text = contact.Nom;
            boxAdresse.Text = contact.Adresse;
            boxPrenom.Text = contact.Prenom;
            boxEmail.Text = contact.Email;
            boxVille.Text = contact.Ville;
            boxCP.Text = contact.Codepostal;
            boxTel.Text = contact.NoTel;
            if (contact.Province == null || contact.Province.Length == 0)
            {
                boxProvince.SelectedItem = null;
                boxProvince.Text = "";
            }
            else
                boxProvince.Text = contact.Province;
        }
        private void ActiverBouton(bool booleen)
        {
            btnModif.Enabled = booleen;
            btnSauve.Enabled = booleen;
            btnAnnuler.Enabled = booleen;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauve_Click(object sender, EventArgs e)
        {
            if (Modification)
            {
                try
                {
                    Liste.SupprimerContact(listeContact.SelectedIndex);
                    Liste.InsererContact(new Contact(boxNom.Text, boxPrenom.Text, boxAdresse.Text, boxCP.Text, boxVille.Text, boxTel.Text, boxEmail.Text, boxProvince.Text),listeContact.SelectedIndex);
                    EntreeSortie.Ecriture(Liste);
                    MessageBox.Show("Contact enregistré");
                    ActiverChamps(false);
                    ViderChamps();
                    RafraichirListe();
                    Modification = false;
                }
                catch (EmailInvalideException exception)
                {
                    MessageBox.Show(exception.Message);
                    boxEmail.SelectAll();
                    boxEmail.Focus();
                }
                catch (CodePostalException exception)
                {
                    MessageBox.Show(exception.Message);
                    boxCP.SelectAll();
                    boxCP.Focus();
                }
                catch (TelephoneInvalideException exception)
                {
                    MessageBox.Show(exception.Message);
                    boxTel.SelectAll();
                    boxTel.Focus();
                }
                catch (ContactDejaPresentException exception)
                {
                    DialogResult dialog = MessageBox.Show(exception.Message + "\nVoulez-vous mettre à jour ?", "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Liste.SupprimerContact(exception.Index);
                        Liste.InsererContact(new Contact(boxNom.Text, boxPrenom.Text, boxAdresse.Text, boxCP.Text, boxVille.Text, boxTel.Text, boxEmail.Text, boxProvince.Text), exception.Index);
                        EntreeSortie.Ecriture(Liste);
                    }
                    else
                    {
                        boxNom.Focus();
                        boxNom.SelectAll();
                    }
                }
            }
            else
            {
                try
                {
                    Liste.AjouterContact(new Contact(boxNom.Text, boxPrenom.Text, boxAdresse.Text, boxCP.Text, boxVille.Text, boxTel.Text, boxEmail.Text, boxProvince.Text));
                    EntreeSortie.Ecriture(Liste);
                    MessageBox.Show("Contact enregistré");
                    ActiverChamps(false);
                    ViderChamps();
                    RafraichirListe();
                }
                catch (EmailInvalideException exception)
                {
                    MessageBox.Show(exception.Message);
                    boxEmail.SelectAll();
                    boxEmail.Focus();
                }
                catch (CodePostalException exception)
                {
                    MessageBox.Show(exception.Message);
                    boxCP.SelectAll();
                    boxCP.Focus();
                }
                catch (TelephoneInvalideException exception)
                {
                    MessageBox.Show(exception.Message);
                    boxTel.SelectAll();
                    boxTel.Focus();
                }
                catch (ContactDejaPresentException exception)
                {
                    DialogResult dialog = MessageBox.Show(exception.Message + "\nVoulez-vous mettre à jour ?", "", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Liste.SupprimerContact(exception.Index);
                        Liste.InsererContact(new Contact(boxNom.Text, boxPrenom.Text, boxAdresse.Text, boxCP.Text, boxVille.Text, boxTel.Text, boxEmail.Text, boxProvince.Text), exception.Index);
                        EntreeSortie.Ecriture(Liste);
                    }
                    else
                    {
                        boxNom.Focus();
                        boxNom.SelectAll();
                    }
                }
            }
        }

        /// <summary>
        /// Bouton pour annuler les changements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ActiverChamps(false);
            ViderChamps();
            ActiverBouton(false);
            Modification = false;
        }
        /// <summary>
        /// Bouton pour supprimer un contact avec boîte de confirmation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupp_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce contact ?", "", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Liste.Registre.Remove(Liste.Registre[listeContact.SelectedIndex]); // A modifier pour utiliser Liste.Supprimer(contact)
                EntreeSortie.Ecriture(Liste);
                ViderChamps();
                RafraichirListe();
                ActiverBouton(false);
            }
        }
        /// <summary>
        /// Clic sur bouton pour modification de contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModif_Click(object sender, EventArgs e)
        {
            ActiverBouton(true);
            ActiverChamps(true);
            RemplirChamps(Liste.Registre[listeContact.SelectedIndex]);
            Modification = true;
        }
        /// <summary>
        /// Bouton pour quitter l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // messagebox pour afficher la version
        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.ProductName + "\nVersion " + Application.ProductVersion);
        }
        private void boxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void boxProvince_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            if (e.Index > -1 && imageList2.Images.Count >= e.Index)
            {
                e.Graphics.DrawImage(imageList2.Images[e.Index], new PointF(e.Bounds.X, e.Bounds.Y));
                e.Graphics.DrawString(boxProvince.Items[e.Index].ToString(), boxProvince.Font,
                Brushes.Black, new RectangleF(e.Bounds.X + 30, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
            }
        }
    }
}
