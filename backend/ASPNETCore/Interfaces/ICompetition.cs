using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetition
    {
        List<Competition> competitions { get; }
    }
}
