using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewComponents
{
    public class FooterMenuViewComponent : ViewComponent
    {
        UnitOfWork unitOfWork;
        public FooterMenuViewComponent(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            var footerfirst = this.unitOfWork.FooterMenus.GetFooterMenuFirstColumn();
            var footersecond = this.unitOfWork.FooterMenus.GetFooterMenuSecondColumn();
            var footerthird = this.unitOfWork.FooterMenus.GetFooterMenuThirdColumn();
            var vm = new FooterViewModel { FooterFirstColumn = footerfirst, FooterSecondColumn = footersecond, FooterThirdColumn = footerthird };
            return View("FooterMenu", vm);
        }
    }
}
