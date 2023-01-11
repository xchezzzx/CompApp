using ASPNETCore.Helpers;
using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore.Repositories
{
    public class CompetitionRepository : ICompetitionsToTeamsToUser
    {
        private readonly CCMSContext _modelsContext;

        public CompetitionRepository(CCMSContext modelsContext)
        {
            _modelsContext = modelsContext;
        }


        public List<Competition> GetAllCompetitions => 
            _modelsContext.Competitions
            .Include("State")
            .Include("Status")
            .ToList();

        public Competition GetCompetitionById(int id) =>
           (_modelsContext.Competitions
            .Include(c => c.State)
            .Include(c => c.Status)
            .Include(c => c.CreateUser)
            .Include(c => c.UpdateUser)
            .Where(c => c.Id == id)
            .FirstOrDefault());

        public void AddNewCompetiton(Competition competition, int createUserID)
        {
            FillEntityHelper.CreateEntity(ref competition, createUserID);
            _modelsContext.Competitions.Add(competition);
            _modelsContext.SaveChanges();
            //return true;
        }

        public void UpdeteCompetiton(Competition competition, int updateUserID)
        {
            FillEntityHelper.UpdateEntity(ref competition, updateUserID);
            _modelsContext.Competitions.Update(competition);
            _modelsContext.SaveChanges();
        }

        public void DeleteCompetiton(Competition competition, int updateUserID)
        {
            FillEntityHelper.DeleteEntity(ref competition, updateUserID);
            _modelsContext.Competitions.Update(competition);
            _modelsContext.SaveChanges();
        }
    }
}
