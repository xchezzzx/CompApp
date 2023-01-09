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
        //private CCMSContext _context;

        private readonly ICompetition competitionRepository;

        public CompetitionHub(ICompetition iCompetiton)
        {

            competitionRepository = iCompetiton;
        }

        public async Task SendCompetitions()
        {
            CCMSContext _context = new();

            CompetitionRepository _repo = new CompetitionRepository(_context);

            List<Competition> competitions = _repo.competitions;

            List<CompetitionDT> competitionsDT = new();

            foreach (var c in competitions)
            {
                competitionsDT.Add(ToDTModelsParsers.DTCompetitionParser(c));
            }

            await Clients.All.SendAsync("Send", competitionsDT);
        }

        public async Task AddNewCompetition(CompetitionDT competitionDT)
        {
            string res = "failed";

            Competition competition = ToDBModelsParsers.CompetitionParser(competitionDT);

            if (competition != null)
            {

                //CompetitionRepository _repo = new CompetitionRepository(_context);
                competitionRepository.addCompetiton(competition);
                res = "success";
            }


            await Clients.Caller.SendAsync("Add", res);
        }
    }

}