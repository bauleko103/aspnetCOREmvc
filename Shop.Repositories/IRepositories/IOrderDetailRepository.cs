﻿using Shop.Entities.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories.IRepositories
{
    public interface  IOrderDetailRepository
    {
        IEnumerable<OrderDetail> SelectAll();
        OrderDetail SelectById(object id);
        void Insert(OrderDetail obj);
        Task Update(OrderDetail obj);
        void Delete(object id);
        void DeleteByItem(OrderDetail id);
        void Save();
    }
}
