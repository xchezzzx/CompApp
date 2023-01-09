using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetition
    {
        List<Competition> competitions { get; }
        void addCompetiton(Competition competition);
    }
}
