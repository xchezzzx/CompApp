using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Repositories
{
    public class CompetitionStatusRepository : ICompetitionStatus
    {
        private readonly CCMSContext _modelsContext;

        public CompetitionStatusRepository(CCMSContext modelsContext)
        {
            _modelsContext = modelsContext;
        }

        public List<CompetitionStatus> competitions => _modelsContext.CompetitionStatuses.ToList();
    }
}
