using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Entities
{
    public class Word
    {
        public int id { get; set; }
        public string Searchable { get; set; }
        public string Name { get; set; }        
        public string? Etimology { get; set; }
        public string? Type { get; set; }
        public string? Gender { get; set; } 
        public string? Meaning { get; set; }
        public string? Inflection { get; set; }
        public string? Observation { get; set; }
    }
}