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
            comedy.someList.Add("Anchorman");
            comedy.name = "Comedy";
            Genre romance = new Genre();
            Genre RomanticComedy = romance + comedy;

        }
    }
}
