using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public abstract class Title
    {
        string name;
        int? rating;

        public Title(string name, int rating)
        {
            name = "";
            rating = 0;

        }
        public Title()
        {
            this.name = null;
            this.rating = null;
        }
    }
}
