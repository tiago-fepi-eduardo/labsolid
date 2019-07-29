using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Infra.Data
{
    public static class LibraryInicializer
    {
        public static void Initializer(LibraryContext context)
        {
            //context.Database.EnsureCreated();
            
            //var lstCategory = new List<CategoryEntity>
            //{
            //    new CategoryEntity{ID = 1, NmCategory = "Ficction"},
            //    new CategoryEntity{ID = 2, NmCategory = "Romance"},
            //    new CategoryEntity{ID = 3, NmCategory = "Comedy"}
            //};

            //lstCategory.ForEach(s => context.Categories.Add(s));
            //context.SaveChanges();


            //var lstBook = new List<BookEntity>
            //{
            //    new BookEntity{ID = 1, NmBook = "Peace and War", VrBook = Convert.ToDecimal(35.5), IdCategory = lstCategory[0] },
            //    new BookEntity{ID = 2, NmBook = "The Little Prince", VrBook = Convert.ToDecimal(35.5), IdCategory = lstCategory[1] },
            //    new BookEntity{ID = 3, NmBook = "Marley", VrBook = Convert.ToDecimal(35.5), IdCategory = lstCategory[2] }
            //};

            //lstBook.ForEach(s => context.Books.Add(s));
            //context.SaveChanges();
        }
    }
}
