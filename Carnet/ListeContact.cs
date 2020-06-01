using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnet
{
    public class ListeContact
    {
        public ListeContact()
        {
        }

        public ListeContact(ObservableCollection<Contact> registre)
        {
            Registre = registre;
        }

        public ObservableCollection<Contact> Registre { get; set; }
        /// <summary>
        /// Fonction d'ajout dans le registre
        /// </summary>
        /// <param name="contact">Contact à ajouter</param>
        /// à finir
        public void AjouterContact(Contact contact)
        {
            if (VerifierContact(contact))
                Registre.Add(contact);
        }
        /// <summary>
        /// Méthode de suppression de contact
        /// </summary>
        /// <param name="contact">Contact à supprimer</param>
        /// à finir
        public void SupprimerContact(Contact contact)
        {
            Registre.Remove(contact);
        }
        /// <summary>
        /// Supprime un contact à l'index donné
        /// </summary>
        /// <param name="index"></param>
        /// à finir en vérifiant
        public void SupprimerContact(int index)
        {
            Registre.RemoveAt(index);
        }
        /// <summary>
        /// Méthode pour vérifier la présence du contact dans le registre
        /// </summary>
        /// <param name="contact">Contact à vérifier</param>
        /// <returns>Booléen</returns>
        public bool VerifierContact(Contact contact)
        {
            for (int i = 0; i < Registre.Count; i++)
            {
                if (Registre[i].Equals(contact))
                    throw new ContactDejaPresentException("Contact déjà présent", Registre[i], i);
            }
            if (!Utilitaire.ValiderEmail(contact.Email))
            {
                throw new EmailInvalideException("Mauvais format d'email", contact.Email);
            }
            if (!Utilitaire.ValiderCP(contact.Codepostal))
            {
                throw new CodePostalException("Mauvais format de code postal", contact.Codepostal);
            }
            if (!Utilitaire.ValiderNoTel(contact.NoTel))
                throw new TelephoneInvalideException("Mauvais numéro de téléphone", contact.NoTel);
            return true;
        }
        /// <summary>
        /// Insére un contact dans le registre à l'index donné
        /// </summary>
        /// <param name="contact">Contact à insérer</param>
        /// <param name="index">Index où le faire</param>
        internal void InsererContact(Contact contact, int index)
        {
            if (VerifierContact(contact))
                Registre.Insert(index, contact);
        }
    }
}
