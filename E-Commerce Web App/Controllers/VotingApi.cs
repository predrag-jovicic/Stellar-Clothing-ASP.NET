using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Commerce_Web_App.Data;
using E_Commerce_Web_App.Models;
using E_Commerce_Web_App.ViewModels.Input;
using E_Commerce_Web_App.ViewModels.Output;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace E_Commerce_Web_App.Controllers
{
    [Route("api/[controller]/vote")]
    public class VotingApi : Controller
    {
        private UserManager<User> userManager;
        private UnitOfWork unitOfWork;
        public VotingApi(UserManager<User> userManager, UnitOfWork unitOfWork)
        {
            this.userManager = userManager;
            this.unitOfWork = unitOfWork;
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Post(VotingInput model)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!ModelState.IsValid)
                    return UnprocessableEntity();
                else
                {
                    string userId = this.userManager.GetUserId(User);
                    short pollId = this.unitOfWork.Polls.GetActivePoll().Poll_id;
                    bool alreadyVoted = this.unitOfWork.Votes.HasAlreadyVoted(userId, pollId);
                    if (alreadyVoted)
                        return Conflict();
                    else
                    {
                        this.unitOfWork.Votes.Vote(model.OptionId, pollId, userId);
                        await this.unitOfWork.Save();
                        IQueryable<VotesViewModel> votes = this.unitOfWork.Options.GetResults(pollId).Select(
                            o => new VotesViewModel
                            {
                                Option = o.Name,
                                NumberOfVotes = o.Votes.Count()
                            });
                        return Ok(votes);
                    }
                }
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
