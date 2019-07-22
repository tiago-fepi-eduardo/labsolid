using Solid.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Service.Interfaces
{
    interface ICategoryService
    {
        void Insert(CategoryEntity categoryEntity);
        void Update(CategoryEntity categoryEntity);
        void Delete(int id);
        CategoryEntity Get(int id);
        IEnumerable<CategoryEntity> List();
    }
}
