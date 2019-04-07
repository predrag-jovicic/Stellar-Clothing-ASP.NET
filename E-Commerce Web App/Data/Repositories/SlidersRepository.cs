using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class SlidersRepository
    {
        private WebStoreContext context;
        public SlidersRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public Slider GetActiveSlider()
        {
            return this.context.Sliders
                .Include(s => s.SliderPhotos)
                .SingleOrDefault(s => s.Active == true);
        }
    }
}
