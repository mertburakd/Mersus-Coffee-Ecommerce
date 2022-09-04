using Core.Results;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetList();
        IDataResult<Product> Get(int Id);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(int productId);
    }
}
