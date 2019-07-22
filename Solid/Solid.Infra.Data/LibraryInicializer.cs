using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Infra.Data
{
    //public class LibraryInicializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    //{
    //    protected override void Seed(LibraryContext context)
    //    {
    //        var lstCategory = new List<CategoryEntity>
    //        {
    //            new CategoryEntity{IdCategory = 1, NmCategory = "Ficction"},
    //            new CategoryEntity{IdCategory = 2, NmCategory = "Romance"},
    //            new CategoryEntity{IdCategory = 3, NmCategory = "Comedy"}
    //        };

    //        lstCategory.ForEach(s => context.Category.Add(s));
    //        context.SaveChanges();


    //        var lstBook = new List<BookEntity>
    //        {
    //            new BookEntity{IdBook = 1, NmBook = "Peace and War", VrBook = Convert.ToDecimal(35.5), IdCategory = lstCategory[0] },
    //            new BookEntity{IdBook = 2, NmBook = "The Little Prince", VrBook = Convert.ToDecimal(35.5), IdCategory = lstCategory[1] },
    //            new BookEntity{IdBook = 3, NmBook = "Marley", VrBook = Convert.ToDecimal(35.5), IdCategory = lstCategory[2] }
    //        };

    //        lstBook.ForEach(s => context.Book.Add(s));
    //        context.SaveChanges();
    //    }
    //}
}
