using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FloorId { get; set; }
        public Floor Floor { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<BookSection> BookSections { get; set; }
    }
}
