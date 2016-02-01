using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Movie : Title
    {
        public int? duration;
        public override string ToString()
        {
            return name + duration;
        }
    }
}
