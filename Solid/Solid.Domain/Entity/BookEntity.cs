using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solid.Domain.Entity
{
    public class BookEntity : BaseEntity
    {
        public string NmBook { get; set; }
        public decimal VrBook { get; set; }
        public CategoryEntity Category { get; set; }
        public int CategoryId { get; set; }
    }
}
