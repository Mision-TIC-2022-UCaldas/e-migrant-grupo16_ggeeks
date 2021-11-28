using System;
using System.ComponentModel.DataAnnotations;

namespace Emigrant.App.Dominio{
    public class Organizacion{
        public int id { get; set; }
        [Required]
        public string razonsocial { get; set; }
        [Required]
        public string nit { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string ciudad { get; set; }
        [Required]
        public string telefono { get; set; }
        public string correo { get; set; }
        public string paginaweb { get; set; }
        [Required]
        public string sector { get; set; }
        [Required]        
        public string servicioofrece { get; set; }
    }
 
}