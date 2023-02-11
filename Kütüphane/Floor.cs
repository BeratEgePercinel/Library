using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Floor
    {
        public int Id { get; set; }
        public int Area { get; set; }
        public string FloorType { get; set; }
        public int Capacity { get; set; }
        public string Nickname { get; set; }
        public List<Section> Sections { get; set; }
    }
}
