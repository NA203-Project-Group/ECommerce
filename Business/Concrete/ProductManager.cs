using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        private IProductDetailDal _productDetailDal;

        public ProductManager(IProductDal productDal, IProductDetailDal productDetailDal)
        {
            _productDal = productDal;
            _productDetailDal = productDetailDal;
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p=>p.Statement == true));
        }

        public IDataResult<Product> Get(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID == id));
        }

        public IResult Add(Product entity)
        {
            //ValidationTool.Validate(new ProductValidator(), entity);

            BusinessRules.Run(CheckProductStatements(entity.ProductID));
            _productDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Product entity)
        {
            BusinessRules.Run(CheckProductStatements(entity.ProductID));
            _productDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Product entity)
        {
            _productDal.Delete(entity);
            return new SuccessResult();
        }

        private IResult CheckProductStatements(int id)
        {
            var productDetail =  _productDetailDal.Get(p => p.ProductID == id);
            Product product = new Product();
            if (productDetail.StockAmount == 0)
            {
                product  = _productDal.Get(p => p.ProductID == id);
                product.Statement = false;
                return new SuccessResult();
            }

            product.Statement = true;
            return new ErrorResult();
        }
    }
}
