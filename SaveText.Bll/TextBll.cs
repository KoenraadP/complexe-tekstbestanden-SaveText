using System;
// System.IO bevat allerlei classes en methodes
// om met mappen en bestanden te werken
using System.IO;

namespace SaveText.Bll
{
    // public want nodig in ander project
    public class TextBll
    {
        // directory: in welke map moet het bestand opgeslagen worden
        // title: onder welke naam moet het bestand opgeslagen worden
        // story: welke tekst komt effectief in het bestand
        public void SaveText(string directory,
            string title, string story)
        {
            // als de directory (map) nog niet bestaatn
            // dan error boodschap aanmaken en 'terug gooien'
            if(!Directory.Exists(directory))
            {
                throw new DirectoryNotFoundException("Directory bestaat niet." +
                                                     " Wil je deze aanmaken?");
            }
        }
    }
}
