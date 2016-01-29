using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Movie : Title
    {
        int duration;
        public string ToString(string name, int duration)
        {
            return name + duration;
        }
    }
}
