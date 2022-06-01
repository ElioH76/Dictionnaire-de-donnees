using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke_Box
{
    class CD
    {
        public string titre;
        public string nom;
        public int nbPistes;
        public string duree;
        public string etat;
        public string avis;

        public CD(string titreSaisi, string nomSaisi, int nbPistesSaisi, string dureeSaisi, string etatSaisi, string avisSaisi)
        {
            titre = titreSaisi;

            nom = nomSaisi;

            nbPistes = nbPistesSaisi;

            duree = dureeSaisi;

            etat = etatSaisi;

            avis = avisSaisi;
        }

        public string getTitre()
        {
            return titre;
        }
        public void setTitre(string nouveauTitre)
        {
            titre = nouveauTitre;
        }

        public string getNom()
        {
            return nom;
        }
        public void setNom(string nouveauNom)
        {
            nom = nouveauNom;
        }

        public int getNbPistes()
        {
            return nbPistes;
        }
        public void setNbPistes(int nouveauNbPistes)
        {
            nbPistes = nouveauNbPistes;
        }

        public string getDuree()
        {
            return duree;
        }
        public void setDuree(string nouveauDuree)
        {
            duree = nouveauDuree;
        }

        public string getEtat()
        {
            return etat;
        }
        public void setEtat(string nouveauEtat)
        {
            etat = nouveauEtat;
        }

        public string getAvis()
        {
            return avis;
        }
        public void setAvis(string nouveauAvis)
        {
            avis = nouveauAvis;
        }

        public void affichercd()
        {
            Console.WriteLine("Informations sur les CD");
            Console.WriteLine("");
            Console.WriteLine("Titre : "+ this.titre);
            Console.WriteLine("Artiste : "+ this.nom);
            Console.WriteLine("Nombres de pistes : "+ this.nbPistes);
            Console.WriteLine("Durée du CD : "+ this.duree);
            Console.WriteLine("Etat du CD : "+ this.etat);
            Console.WriteLine("Avis : "+ this.avis);
        }
    }
}
