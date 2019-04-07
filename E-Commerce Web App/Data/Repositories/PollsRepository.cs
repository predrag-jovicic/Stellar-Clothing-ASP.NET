using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class PollsRepository
    {
        WebStoreContext context;
        public PollsRepository(WebStoreContext context)
        {
            this.context = context;
        }
        public Poll GetActivePoll()
        {
            return this.context.Polls
                .Include(p => p.Options)
                .SingleOrDefault(p => p.Active == true);
        }
    }
}
