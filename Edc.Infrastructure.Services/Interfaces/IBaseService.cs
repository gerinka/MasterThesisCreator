﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Edc.Domain.Common;

namespace Edc.Domain.Services.Interfaces
{
    public interface IBaseService<T> where T: class
    {
        T GetById(int id);
        T GetByName(string name);
        T Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}
