using System;

namespace Juke_Box
{
    class Program
    {
        static void Main(string[] args)
        {

            Biblio uneBiblio = new Biblio();

            Console.WriteLine("================================================================================================================");

            CD CD1 = new CD("Jvlivs II", "SCH", 21,"54:47","Neuf","5/5");
            uneBiblio.AjoutCD(CD1);
            CD1.affichercd();

            Console.WriteLine("================================================================================================================");

            Videos uneVideo = new Videos("La ligne verte", "Franck Darabont", "Tom Hanks, Michael Clarke Duncan", "188 minutes (3h08)", "25 DVD restant", "Film émouvant");
            uneBiblio.AjoutFilm(uneVideo);
            uneVideo.afficherf();

            Console.WriteLine("================================================================================================================");
        }
    }
}
