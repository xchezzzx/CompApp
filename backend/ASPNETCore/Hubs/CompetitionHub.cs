using ASPNETCore.Helpers;
using ASPNETCore.Models.DTModels;
using ASPNETCore.Models.DBModels;
using ASPNETCore.Repositories;
using Microsoft.AspNetCore.SignalR;

namespace ASPNETCore.Hubs
{
    public class CompetitionHub : Hub
    {
        private readonly CCMSContext _context = new();

        public async void SendCompetitions()
        {

            CompetitionRepository _repo = new(_context);

            List<Competition> competitions = _repo.competitions;

            List<CompetitionDT> competitionsDT = new();

            foreach (var c in competitions)
            {
                competitionsDT.Add(new CompetitionDT(c));
            }

            await Clients.Caller.SendAsync("Send", competitionsDT);




        }

        public async void AddCompetition(CompetitionDT competitionDT)
        {
            string res = "failed";

            Competition competition = ToDBModelsParsers.CompetitionParser(competitionDT);

            if (competition != null)
            {
                _context.Competitions.Add(competition);
                res = "success";
            }

            
            await Clients.Caller.SendAsync("Add", res);
        }
    }
}