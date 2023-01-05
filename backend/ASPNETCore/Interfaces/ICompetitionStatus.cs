using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetitionStatus
    {
        List<CompetitionStatus> competitions { get; }
    }
}
