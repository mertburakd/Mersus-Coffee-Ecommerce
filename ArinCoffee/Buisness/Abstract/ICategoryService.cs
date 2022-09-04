using Core.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        IDataResult<Category> Get(int Id);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(int categoryId);
    }
}
