﻿using H9ShoesShopApp.Models.Entities;
using H9ShoesShopApp.ViewModel.Order;
using H9ShoesShopApp.ViewModel.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H9ShoesShopApp.Models.Repository
{
    public interface IOrderRepository
    {
        int CreateOrder(Order order);
        IEnumerable<Order> Gets();
        bool DeleteOrder(int id);
        Order GetOrder(int id);
        int ChangeStatus(int id, bool status);
        int UndoDelete(int id);

    }
}
