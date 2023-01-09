using BlazorWeb.Models.DataTransferModels;

namespace BlazorWeb.Interfaces
{
    public interface ICompetitionService
    {
        Task<List<CompetitionDT>> GetAllCompetitionsAsync();
        Task AddCompetition(CompetitionDT competitionDT);
    }
}
