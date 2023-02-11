using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public int Salary { get; set; }
        public int SectionId { get; set; }
        public List<Section> Sections { get; set; }
    }
}
