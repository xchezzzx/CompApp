using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetitionsToTeamsToUser
    {
        List<CompetitionsToTeamsToUser> GetAllCompetitionsToTeamsToUser{ get; }
        List<User> GetParticipantsByCompetitionId(int competitionId);
        void AddUserToTeamToCompetiton(int userId, int competitionId, int teamId);
        void SwitchUserTeam(int userId, int competitionId, int newTeamId);
        bool IfUserIsCompetitionParticipant(int userId, int competitionId);
    }
}
