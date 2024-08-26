using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySistem.Models
{
    [Table("document_types")] // Nombre de la DB
    public class DocumentType
    {
        [Key] //PK de la base de datos
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        [MinLength(50, ErrorMessage="The name field must be at most 50 characters")]

        public required string Name { get; set; }
        
        [Column("abbreviation")]
        [MaxLength(2, ErrorMessage="The abbreviation field must have at least 2 characters")]
        [MinLength(10, ErrorMessage="The abbreviation field must be at most 10 characters")]

        public required string Abbreviation { get; set; }
        
        
        [Column("description")]
        public string? Description { get; set; }

        /* Otras DataAnnotations en la imagen */

    }
}