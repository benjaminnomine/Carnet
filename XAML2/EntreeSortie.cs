using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace XAML2
{
    public static class EntreeSortie
    {
        /// <summary>
        /// Lecture du fichier txt qui sert de BDD et alimente Liste.Registre
        /// </summary>
        /// <param name="liste">Liste à alimenter</param>
        public static void Lecture(ListeContact liste)
        {
            StreamReader reader = null;
            if (!File.Exists("database.txt"))
                File.Create("database.txt");
            try
            {
                reader = new StreamReader("database.txt");
                string data = null;
                while ((data = reader.ReadLine()) != null)
                {
                    Contact cont = Utilitaire.ParseLigne(data);
                    liste.AjouterContact(cont);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }
        /// <summary>
        /// Méthode IO pour écrire le fichier database.txt
        /// </summary>
        /// <param name="liste">Liste à écrire dans le fichier</param>
        public static void Ecriture(ListeContact liste)
        {
            using (StreamWriter writer = new StreamWriter("database.txt"))
            {
                foreach (Contact contact in liste.Registre)
                {
                    writer.WriteLine(Utilitaire.FormerLigne(contact));
                }
            }
        }
    }
}
