using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Genre comedy = new Genre();
            Genre romance = new Genre();
            TvShow tvShow = new TvShow();
            Episode episode = new Episode();
            
            List<string> Comedy = new List<string>();
            Comedy.Add("Anchorman");
            Comedy.Add("The Animal");

            List<string> Romance = new List<string>();
            Romance.Add("Trainwreck");
            Romance.Add("Titanic");

            
            Movie Anchorman = new Movie();
            Anchorman.name = "Anchorman";
            Anchorman.rating = 4;
            Anchorman.duration = 94;

            Movie TheAnimal = new Movie();
            TheAnimal.name = "The Animal";
            TheAnimal.rating = 2;
            TheAnimal.duration = 83;

            Movie Trainwreck = new Movie();
            Trainwreck.name = "Trainwreck";
            Trainwreck.rating = 3;
            Trainwreck.duration = 125;

            Movie Titanic = new Movie();
            Titanic.name = "Titanic";
            Titanic.rating = 5;
            Titanic.duration = 194;


            tvShow.name = "Walking Dead Season 1";
            tvShow.numberOfEpisodes = 6;
            List<string> Episodes = new List<string>();
            Episodes.Add("Days Gone By");
            Episodes.Add("Guts");
            Episodes.Add("Tell it to the frogs");
            Episodes.Add("Vatos");
            Episodes.Add("Wildfire");
            Episodes.Add("TS -19");
            Episode DaysGoneBy = new Episode();
            DaysGoneBy.rating = 5;
            
            Episode Guts = new Episode();
            Guts.rating = 5;
            Episode TellItToTheFrogs = new Episode();
            TellItToTheFrogs.rating = 4;
            Episode Vatos = new Episode();
            Vatos.rating = null;
            Episode Wildfire = new Episode();
            Wildfire.rating = 3;
            Episode TS19 = new Episode();
            TS19.rating = 4;
            






            

            


        }
    }
}
