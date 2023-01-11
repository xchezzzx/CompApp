using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Interfaces
{
    public interface ICompetitionsToTeamsToExercise
    {
        List<CompetitionsToTeamsToTask> GetAllCompetitionsToTeamsToExercise { get; }
        List<Exercise> GetAllTeamTakenExercises(int teamId, int competitionId);
        List<Team> GetTeamsTakenExercise(int exerciseId, int competitionId);
        void AddExerciseToTeam(int teamId, int competitionId, int exerciseId);
        void RemoveExerciseFromTeam(int teamId, int competitionId, int exerciseId);
    }
}
