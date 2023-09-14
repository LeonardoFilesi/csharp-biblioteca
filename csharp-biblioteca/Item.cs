using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Item
    {

        public string IdCode { get; set; }
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public string Sector { get; set; }
        public string Placement { get; set; }
        public string Author { get; set; }

        // COSTRUTTORE LibraryItem:

        public Item(string idCode, string title, string releaseDate, string sector, string placement, string author)
        {   

            this.IdCode = idCode;
            this.Title = title;
            this.ReleaseDate = releaseDate;
            this.Sector = sector;
            this.Placement = placement;
            this.Author = author;
        }
    }
    //----------------------SOTTOCLASSI------------------
    public class Dvd : Item
    {
        public string Duration { get; set; }

        // COSTRUTTORE Dvd:

        public Dvd(string idCode, string title, string releaseDate, string sector, string placement, string author, string duration) : base(idCode, title, releaseDate, sector, placement, author)
        {
            this.Duration = duration;
        }
    }

    public class Book : Item
    {
        public string PagesNumber { get; set; }

        // COSTRUTTORE Books
        public Book(string idCode, string title, string releaseDate, string sector, string placement, string author, string pagesNumber) : base(idCode, title, releaseDate, sector, placement, author)
        {
            this.PagesNumber = pagesNumber;
        }
    }
}
