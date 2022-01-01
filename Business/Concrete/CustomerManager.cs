﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public DataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public DataResult<Customer> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Result Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Result Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Result Delete(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}