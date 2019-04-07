using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewComponents
{
    public class HeadingMenuViewComponent : ViewComponent
    {
        UnitOfWork unitOfWork;
        public HeadingMenuViewComponent(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            var topItems = this.unitOfWork.HeadingMenus.GetToptems(); 
            HeadingMenuViewModel vm = new HeadingMenuViewModel();
            vm.Count = this.unitOfWork.HeadingMenus.NumberOfColumns();
            vm.Items = new List<HeadingMenuItem>();
            foreach (var item in topItems)
            {
                HeadingMenuItem hmi = new HeadingMenuItem
                {
                    HeadingItem_id = item.HeadingItem_id,
                    Link = item.Link,
                    HasChildren = item.HasChildren,
                    Name = item.Name,
                    Parent = item.Parent,
                    Item_Column = item.Item_Column
                };
                hmi.Children = this.unitOfWork.HeadingMenus.GetChildren(item.HeadingItem_id).ToList();
                vm.Items.Add(hmi);
            }
            return View("HeadingMenu",vm);
        }
    }
}
