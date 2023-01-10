using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore.Repositories
{
	public class CompetitionRepository : ICompetition
	{
		private readonly CCMSContext _modelsContext;

		public CompetitionRepository(CCMSContext modelsContext)
		{
			_modelsContext = modelsContext;
		}


		public List<Competition> competitions => _modelsContext.Set<Competition>().Include("State").Include("Status").ToList();

		public void addCompetiton(Competition competition)
		{
			_modelsContext.Competitions.Add(competition);
			_modelsContext.SaveChanges();
		}
	}
}