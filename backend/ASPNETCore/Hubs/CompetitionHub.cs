using ASPNETCore.Helpers;
using ASPNETCore.Models.DTModels;
using ASPNETCore.Models.DBModels;
using ASPNETCore.Repositories;
using Microsoft.AspNetCore.SignalR;
using ASPNETCore.Interfaces;

namespace ASPNETCore.Hubs
{
    public class CompetitionHub : Hub
    {
        private CCMSContext _context = new CCMSContext();
        

        public async Task SendCompetitions()
        {


            CompetitionRepository _repo = new CompetitionRepository(_context);

            List<Competition> competitions = _repo.competitions;

            List<CompetitionDT> competitionsDT = new();

            foreach (var c in competitions)
            {
                competitionsDT.Add(ToDTModelsParsers.DTCompetitionParser(c));
            }



            await Clients.Caller.SendAsync("Send", competitionsDT);




        }

        public async Task AddNewCompetition(CompetitionDT competitionDT)
        {
            string res = "failed";

            Competition competition = ToDBModelsParsers.CompetitionParser(competitionDT);

            if (competition != null)
            {
                ICompetition _repo = new CompetitionRepository(_context);
				_repo.addCompetiton(competition);
                res = "success";
            }


            await Clients.Caller.SendAsync("Add", res);
        }
    }

}