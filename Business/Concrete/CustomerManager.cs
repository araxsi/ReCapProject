﻿using Core.Utilities.Results;
using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult();
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult();
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<List<Customer>> GetById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.Id == id));
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult();
        }
    }
}