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
            yield return title ;
        }
        public List<Title> title;
        public static Genre operator +(Genre genre1, Genre genre2)
        {
            Genre newGenre = new Genre();
            newGenre.title.AddRange(genre1.title);
            newGenre.title.AddRange(genre2.title);
            return newGenre;
        }
        public static Genre operator +(Genre newGenre, Title title)
        {
            Genre newGenreTitle = new Genre();
            newGenreTitle.title.AddRange(newGenreTitle.title);
            newGenreTitle.title.Add(title);
            return newGenreTitle;
        }
    }
}