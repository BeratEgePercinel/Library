using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Writer { get; set; }
        public int PageCount { get; set; }
        public DateTime PublicationDate { get; set; }
        public List<BookSection> BookSections { get; set; }
    }
}
