using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class BookSection
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
