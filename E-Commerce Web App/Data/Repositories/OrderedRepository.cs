using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class OrderedRepository
    {
        private WebStoreContext context;

        public OrderedRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public void Create(Ordered ordered)
        {
            this.context.Add(ordered);
        }
    }
}
