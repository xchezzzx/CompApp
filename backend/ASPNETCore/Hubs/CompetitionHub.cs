using ASPNETCore.Models.DataTransferModels;
using ASPNETCore.Models.DBModels;
using ASPNETCore.Repositories;
using Microsoft.AspNetCore.SignalR;

namespace ASPNETCore.Hubs
{
    public class CompetitionHub : Hub
    {

        CCMSContext _context = new CCMSContext();

        public async void SendCompetitions()
        {
            //List<User> users = _iuser.GetUsers.ToList();


            CompetitionRepository _repo = new CompetitionRepository(_context);

            List<Competition> competitions = _repo.competitions;

            List<CompetitionDT> competitionsDT = new List<CompetitionDT>();

            foreach (var c in competitions)
            {
                competitionsDT.Add(new CompetitionDT(c));
            }

            await Clients.All.SendAsync("Send", competitionsDT);

        }

        public async void AddCompetition(Competition competition)
        {
            _context.Competitions.Add(competition);

            await Clients.Caller.SendAsync("Add", "Success");
        }
    }
}
