using E_Commerce_Web_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class FooterMenusRepository
    {
        WebStoreContext context;
        public FooterMenusRepository(WebStoreContext context)
        {
            this.context = context;
        }
        public IEnumerable<FooterMenu> GetFooterMenuFirstColumn()
        {
            return this.context.FooterMenus;
        }
        public IEnumerable<HeadingMenu> GetFooterMenuSecondColumn()
        {
            return this.context.HeadingMenus.Where(h => h.Parent == this.context.HeadingMenus.First(he => he.HasChildren == true).HeadingItem_id);
        }
        public IEnumerable<HeadingMenu> GetFooterMenuThirdColumn()
        {
            return this.context.HeadingMenus.Where(h => h.Parent == this.context.HeadingMenus.Last(he => he.HasChildren == true).HeadingItem_id);
        }
    }
}
