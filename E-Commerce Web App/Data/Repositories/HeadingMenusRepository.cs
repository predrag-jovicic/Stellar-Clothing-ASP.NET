using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class HeadingMenusRepository
    {
        WebStoreContext context;

        public HeadingMenusRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public IEnumerable<HeadingMenu> GetToptems()
        { 
            var items = this.context.HeadingMenus.Where(m => m.Parent == 0);
            return items;
        }

        public IEnumerable<HeadingMenu> GetChildren(int id)
        {
            return this.context.HeadingMenus.Where(m => m.Parent == id);
        }

        public byte NumberOfColumns()
        {
            return this.context.HeadingMenus.Max(m => m.Item_Column);
        }
    }
}
