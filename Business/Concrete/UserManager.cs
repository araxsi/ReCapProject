﻿using Core.Utilities.Results;
using Business.Abstract;
using Business.Constans;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Core.Entities.Concrete;

namespace Business.Concrete
    {
        public class UserManager : IUserService
        {
            IUserDal _userDal;
            public UserManager(IUserDal userDal)
            {
                _userDal = userDal;
            }

            public IResult Add(User user)
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdd);
            }

            public IResult Delete(User user)
            {
                _userDal.Delete(user);
                return new SuccessResult();
            }

            public IDataResult<List<User>> GetAll()
            {
                return new SuccessDataResult<List<User>>(_userDal.GetAll());
            }

            public IDataResult<User> GetById(int id)
            {
                return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
            }

            public IResult Update(User user)
            {
                _userDal.Update(user);
                return new SuccessResult();
            }

            public List<OperationClaim> GetClaims(User user)
            {
                return _userDal.GetClaims(user);
            }

            
            public User GetByMail(string email)
            {
                return _userDal.Get(u => u.Email == email);
            }
        }
    }

