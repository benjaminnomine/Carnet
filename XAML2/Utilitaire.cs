using System;
using System.Text.RegularExpressions;

namespace XAML2
{
    internal class Utilitaire
    {
        /// <summary>
        /// Méthode qui permet de sérialiser
        /// </summary>
        /// <param name="ligne">String à transformer en contact</param>
        /// <returns></returns>
        internal static Contact ParseLigne(string ligne)
        {
            //nom, prénom, adresse, cp, ville, téléphone, email, province
            string[] tableau = ligne.Split(';');
            return new Contact(tableau[0], tableau[1], tableau[2], tableau[3], tableau[4], tableau[5], tableau[6], tableau[7]);
        }
        /// <summary>
        /// Méthode qui permet de désérialiser
        /// </summary>
        /// <param name="contact">Contact à transformer en string</param>
        /// <returns></returns>
        internal static string FormerLigne(Contact contact)
        {
            return contact.Nom + ";" + contact.Prenom + ";" + contact.Adresse + ";" + contact.Codepostal.ToUpper() + ";" + contact.Ville + ";" + contact.NoTel + ";" + contact.Email + ";" + contact.Province;
        }
        /// <summary>
        /// Expression régulière pour vérifier le format de l'email
        /// </summary>
        /// <param name="email">String Email à vérifier</param>
        /// <returns></returns>
        internal static bool ValiderEmail(string email)
        {
            string motif = @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            if (string.IsNullOrWhiteSpace(email))
                return true;
            else if (!Regex.IsMatch(email, motif))
                throw new EmailInvalideException("Format d'email non valide", email);
            else
                return true;
        }
        /// <summary>
        /// Expression régulière pour vérifier le format du CP
        /// </summary>
        /// <param name="cp">String Code postal à vérifier</param>
        /// <returns></returns>
        internal static bool ValiderCP(string cp)
        {
            string motif = @"[A-Z][0-9][A-Z][0-9][A-Z][0-9]";
            if (string.IsNullOrWhiteSpace(cp))
                return true;
            else if (cp.Length > 6)
            {
                throw new CodePostalException("Format de code postal non valide", cp);
            }
            else if (Regex.IsMatch(cp.ToUpper(), motif))
                return true;
            else
                return false;
        }
        /// <summary>
        /// Vérification du numéro de téléphone
        /// </summary>
        /// <param name="noTel"></param>
        /// <returns></returns>
        internal static bool ValiderNoTel(string noTel)
        {
            if (string.IsNullOrWhiteSpace(noTel))
                return true;
            else if (noTel.Length > 10)
                throw new TelephoneInvalideException("Numéro de téléphone trop long", noTel);
            else if (noTel.Length < 10 && noTel.Length > 0)
                throw new TelephoneInvalideException("Numéro de téléphone trop court", noTel);
            else
            {
                for (int i = 0; i < noTel.Length; i++)
                {
                    if (Char.IsLetter(noTel[i]))
                        throw new TelephoneInvalideException("Numéro de téléphone avec des lettres non valide", noTel);
                }
            }
            return true;
        }
    }
}