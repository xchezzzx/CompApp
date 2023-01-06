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

        public List<Competition> competitions => _modelsContext.Competitions.Include(c => c.Status).ToList();
        
        
        


    }
}
