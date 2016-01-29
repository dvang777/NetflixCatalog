using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TvShow : Title
    {
        List<Episode> Episodes;
        int amount;
        int AvgRating;
        string name;
        int numberOfEpisodes;


        public new int rating
        {
            get
            {
                return AvgRating;
            }
            set
            {
                amount = rating * Episodes.Count;
                AvgRating = amount / Episodes.Count;
            }
        }
        public override string ToString()
        {
            return name + numberOfEpisodes;
        }
    }
}
