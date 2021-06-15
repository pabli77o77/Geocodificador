using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_GEO.Entidades
{
    public class Localizacion
    {
        [Key]
        public int id { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string ciudad { get; set; }
        public string codigo_Postal { get; set; }
        public string provincia { get; set; }
        public string pais { get; set; }
    }
}
