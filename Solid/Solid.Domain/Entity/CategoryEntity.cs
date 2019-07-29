using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Domain.Entity
{
    public class CategoryEntity : BaseEntity
    {
        public string NmCategory { get; set; }

        public virtual IEnumerable<BookEntity> LstBook { get; set; }
    }
}
