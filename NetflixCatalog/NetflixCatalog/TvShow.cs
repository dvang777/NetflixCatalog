using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TvShow : Title
    {
        public List<Episode> Episodes;
        public int amount;
        public int AvgRating;
        public int numberOfEpisodes;


        public new int rating
        {
            get
            {
                return AvgRating;
            }
            set
            {
                foreach(Episode Episodes in Episodes)
                {
                    amount = rating++;
                }
                  AvgRating = amount / Episodes.Count;  
            }
        }
        public override string ToString()
        {
            return name + numberOfEpisodes;
        }
    }
}
