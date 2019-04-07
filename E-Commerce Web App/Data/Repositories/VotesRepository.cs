using E_Commerce_Web_App.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.Data.Repositories
{
    public class VotesRepository
    {
        private WebStoreContext context;

        public VotesRepository(WebStoreContext context)
        {
            this.context = context;
        }

        public bool HasAlreadyVoted(string userId, int pollId)
        {
            return this.context.Votes
                .Include(v => v.Option)
                .Any(v => v.Option.Poll_id == pollId && v.UserId == userId);
        }

        public void Vote(int optionId, int pollId, string userId)
        {
            Vote newVote = new Vote
            {
                Option_id = optionId,
                Time = DateTime.UtcNow,
                UserId = userId
            };
            this.context.Add(newVote);
        }
    }
}
