using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Genre : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return "";
        }
        public List<Title> someList;
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre newGenre = new Genre();
            newGenre.someList.AddRange(genre1.someList);
            newGenre.someList.AddRange(genre2.someList);
            return newGenre;
        }
        public static Genre operator +(Genre newGenre, Genre title)
        {
            Genre  newGenreTitle = new Genre();
            newGenreTitle.someList.AddRange(newGenreTitle.someList);
            newGenreTitle.someList.AddRange(title.someList);
            return newGenreTitle;
        }






    }

    class GenreTitle
    {
    }
}
