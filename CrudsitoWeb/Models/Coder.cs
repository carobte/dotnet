using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudsitoWeb.Models
{
    public class Coder
    {
        public int Id { get; set; }
        public string? Nombre { get; set;}
        public string? Apellido { get; set; }
        public int AlturaCM { get; set; }
    }
}