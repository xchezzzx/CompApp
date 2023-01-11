using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetitionsToTeamsToUser
    {
        List<Competition> GetAllCompetitions { get; }
        void AddNewCompetiton(Competition competition, int userCreateId);
    }
}
