using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RLS.AwesomeBar.API.Database
{
    public class Cocktail
    {
        
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string AlternateName { get; set; }
        public string Tags { get; set; }
        public string Category { get; set; }
        public string Instructions { get; set; }
        public string Image { get; set; }
        public string Ingredients { get; set; }

        public string Measures { get; set; }
    }
}
