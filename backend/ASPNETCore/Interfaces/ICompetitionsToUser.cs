using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetitionsToUser
    {
        List<CompetitionsToUser> GetAllCompetitionsToUser { get; }
        List<User> GetAdministratorsByCompetitionId(int competitionId);
        List<Competition> GetCompetitionsByAdministratorId (int administratorId);
        void AddAdministratorToCompetiton(int competitionId, int administratorId);
        void RemoveAdministratorFromCompetition(int competitionId, int administratorId);
        bool IfUserIsCompetitionAdministrator(int competitionId, int user);
    }
}
