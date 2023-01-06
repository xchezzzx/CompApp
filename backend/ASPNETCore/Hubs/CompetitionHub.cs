using ASPNETCore.Models.DataTransferModels;
using ASPNETCore.Models.DBModels;
using ASPNETCore.Repositories;
using Microsoft.AspNetCore.SignalR;

namespace ASPNETCore.Hubs
{
    public class CompetitionHub : Hub
    {
        public async void SendCompetitions()
        {
            //List<User> users = _iuser.GetUsers.ToList();

            CCMSContext _context = new CCMSContext();

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
            try
            {
                _context.Competitions.Add(competition);
            }
            catch (Exception ex)
            {

            }
            
            await Clients.Caller.SendAsync("Add", "Success");
            }
    }
}
