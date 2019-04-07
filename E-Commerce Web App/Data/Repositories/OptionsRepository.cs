using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class OptionsRepository
    {
        WebStoreContext context;
        public OptionsRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public IQueryable<Option> GetResults(int pollId)
        {
            return this.context.Options
                .Include(o => o.Votes)
                .Where(o => o.Poll_id == pollId);
        }
    }
}
