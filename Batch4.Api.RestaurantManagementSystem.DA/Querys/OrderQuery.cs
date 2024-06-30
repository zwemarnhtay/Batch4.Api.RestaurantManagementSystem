﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.RestaurantManagementSystem.DA.Querys
{
    public static class OrderQuery
    {
        public static string OrderDetailQuery { get; } = @"select mi.ItemName,mi.ItemPrice,od.Quantity
                                                               from Tbl_MenuItem mi inner join Tbl_OrderDetail od 
                                                               on mi.ItemId = od.ItemId
                                                                where od.InvoiceNo=@InvoiceNo";
    }
}
