﻿    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopModel.Model
{

    public class Order
    {
        public Order() { }

        public Order(int id, int customerId, DateTime date) { 
            this.ID= id;
            this.customerId = customerId;
            this.orderDate= date;
        
        }
        public Order(int customerId, DateTime date)
        {
        
            this.customerId = customerId;
            this.orderDate = date;

        }

        public int ID { get; set; }

        public int customerId { get; set; }
        public DateTime orderDate { get; set; }


    }

}
