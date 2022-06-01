using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke_Box
{
    class Videos
    {
        public string titre;
        public string nom;
        public string acteur;
        public string duree;
        public string etat;
        public string avis;

        public Videos(string titreSaisi, string nomSaisi, string acteurSaisi, string dureeSaisi, string etatSaisi, string avisSaisi)
        {
            titre = titreSaisi;

            nom = nomSaisi;

            acteur = acteurSaisi;

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

        public string getActeur()
        {
            return acteur;
        }
        public void setActeur(string nouveauActeur)
        {
            acteur = nouveauActeur;
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

        public void afficherf()
        {
            Console.WriteLine("Informations sur les films");
            Console.WriteLine("");
            Console.WriteLine("Titre : " + this.titre);
            Console.WriteLine("Metteur en scène : " + this.nom);
            Console.WriteLine("Acteur Principal : " + this.acteur);
            Console.WriteLine("Durée du film : " + this.duree);
            Console.WriteLine("Etat du stock : " + this.etat);
            Console.WriteLine("Avis : " + this.avis);
        }
    }
}
