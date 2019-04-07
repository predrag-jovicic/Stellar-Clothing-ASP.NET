using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Data.Repositories;
using E_Commerce_Web_App.Models;
namespace E_Commerce_Web_App.Data
{
    public class UnitOfWork
    {
        WebStoreContext context;

        public ProductsRepository Products { get; private set; }
        public SlidersRepository Sliders { get; private set; }
        public FooterMenusRepository FooterMenus { get; private set; }
        public HeadingMenusRepository HeadingMenus { get; private set; }
        public PollsRepository Polls { get; private set; }
        public PricesRepository Prices { get; private set; }
        public ProductVariantsRepository ProductVariant { get; private set; }
        public ColorsRepository Colors { get; set; }
        public VotesRepository Votes { get; set; }
        public OptionsRepository Options { get; set; }
        public RatingsRepository Ratings { get; set; }
        public OrderedRepository Ordered { get; set; }
        public OrdersRepository Orders { get; set; }

        public UnitOfWork(WebStoreContext context)
        {
            this.context = context;
            Products = new ProductsRepository(context);
            Sliders = new SlidersRepository(context);
            FooterMenus = new FooterMenusRepository(context);
            HeadingMenus = new HeadingMenusRepository(context);
            Polls = new PollsRepository(context);
            Prices = new PricesRepository(context);
            ProductVariant = new ProductVariantsRepository(context);
            Colors = new ColorsRepository(context);
            Votes = new VotesRepository(context);
            Options = new OptionsRepository(context);
            Ratings = new RatingsRepository(context);
            Ordered = new OrderedRepository(context);
            Orders = new OrdersRepository(context);
        }

        public async Task Save()
        {
            await this.context.SaveChangesAsync();
        }
    }
}
