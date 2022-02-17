﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_129_ADO.NET_EF_AutoLotDAL.Repos
{
    public interface IRepo<T>
    {
        int Add(T entity);
        int AddRange(IList<T> entities);
        int Save(T entity);
        int Delete(int id, byte[] timeStamp);
        int Delete(T entity);
        List<T> GetAll();
        List<T> ExecuteQuery(string sql);
        List<T> ExecuteQuery(string sql, object[] sqlParametrsObjects);
    }
}
