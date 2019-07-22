using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solid.Domain.Entity
{
    public class BookEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdBook { get; set; }
        public string NmBook { get; set; }
        public decimal VrBook { get; set; }
        public CategoryEntity IdCategory { get; set; }
    }
}
