using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juke_Box
{
    class Biblio
    {
        List<CD> lesCDs = new List<CD>();
        List<Videos> lesVideos = new List<Videos>();

        public void AjoutCD(CD unCD)
        {

            lesCDs.Add(new CD(unCD.getTitre(), unCD.getNom(), unCD.getNbPistes(), unCD.getDuree(), unCD.getEtat(), unCD.getAvis()));
        }
        public void AjoutFilm(Videos uneVideos)
        {

            lesVideos.Add(new Videos(uneVideos.getTitre(), uneVideos.getNom(), uneVideos.getActeur(), uneVideos.getDuree(), uneVideos.getEtat(), uneVideos.getAvis()));
        }

        public void afficheCD()
        {
            Console.WriteLine(lesCDs);
        }

        public void afficheF()
        {
            Console.WriteLine(lesVideos);
        }
    }
}
