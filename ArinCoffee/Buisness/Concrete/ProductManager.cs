using Buisness.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buisness.Concrete
{
    public class ProductManager : IProductService
    {

        private readonly IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList());
        }
        public IDataResult<Product> Get(int Id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(q => q.ProductId == Id));
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Delete(int productId)
        {
            _productDal.Delete(_productDal.Get(q=>q.ProductId==productId));
            return new SuccessResult(Messages.ProductDeleted);
        }
    }
}
