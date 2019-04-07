using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Models;
namespace E_Commerce_Web_App.Data.Repositories
{
    public class OrdersRepository
    {
        private WebStoreContext context;
        public OrdersRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public void Create(Order order)
        {
            this.context.Orders.Add(order);
        }
    }
}
