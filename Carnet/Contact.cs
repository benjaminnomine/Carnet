using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnet
{
    public class Contact
    {
        public Contact(string nom, string prenom, string adresse, string codepostal, string ville, string noTel, string email, string province)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            Codepostal = codepostal;
            Ville = ville;
            NoTel = noTel;
            Email = email;
            Province = province;
        }

        [Browsable(true), Category("Properties"), Description("Identifie le nom du contact")]
        public string Nom { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie le prénom du contact")]
        public string Prenom { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie l'adresse du contact")]
        public string Adresse { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie le CP du contact")]
        public string Codepostal { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie la ville du contact")]
        public string Ville { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie le numéro de téléphone du contact")]
        public string NoTel { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie l'email du contact")]
        public string Email { get; set; }
        [Browsable(true), Category("Properties"), Description("Identifie la province du contact")]
        public string Province { get;set;}
        public string NomComplet { get { return $"{Nom} {Prenom}"; } }

        /// <summary>
        /// Redéfinition de ToString
        /// </summary>
        /// <returns>Nom Complet</returns>
        public override string ToString()
        {
            return NomComplet; 
        }
        /// <summary>
        /// Redéfinition de Equals pour comparer les contacts, comparaison sur nom et prénom
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Contact))
                return false;
            Contact tmp = (Contact)obj;
            if (!Nom.Equals(tmp.Nom))
                return false;
            if (!Prenom.Equals(tmp.Prenom))
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = 1376723973;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Prenom);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Adresse);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Codepostal);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Ville);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(NoTel);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }
    }
}
