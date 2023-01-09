using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;
using System.Data.Entity;

namespace ASPNETCore.Repositories
{
    public class CompetitionRepository : ICompetition
    {
        private readonly CCMSContext _modelsContext;

        public CompetitionRepository(CCMSContext modelsContext)
        {
            _modelsContext = modelsContext;
        }

        //Competition competition = new Competition()
        //{
        //    CompetitionName = "CompetitionName",
        //    DateCreate = DateTime.Now,
        //    DateUpdate = DateTime.Now,
        //    EndTime = DateTime.Now.AddDays(1),
        //    StartTime = DateTime.Now,
        //    Duration = DateTime.Now.AddDays(1) - DateTime.Now,
        //    Hashtag = "Hashtag",
        //    NumberConcTasks = 3,
        //    //Status= comps[0].Status,
        //    StatusId = 1,
        //    UserCreateId = 1,
        //    UserUpdateId = 1
        //};

        public List<Competition> competitions => _modelsContext.Competitions.Include(c => c.Status).Include(c => c.State).ToList();

        public void addCompetiton(Competition competition) 
        { 
            _modelsContext.Competitions.Add(competition); 
            _modelsContext.SaveChanges(); 
        }
    }
}
