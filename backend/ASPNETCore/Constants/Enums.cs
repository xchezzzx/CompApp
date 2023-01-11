namespace ASPNETCore.Constants
{
    enum EntityStatuses : short
    {
        active = 1,
        inactive = 2
    }

    enum UserRoles
    {
        systemAdministrator = 1,
        competitionAdministrator = 2, 
        participant = 3, 
        spectator = 4,
    }

    enum CompetitionStates
    {
        planned = 1,
        inProgress = 2, 
        ended = 3,
        canceled = 4, 
        dropped = 5
    }

    enum ExerciseStates
    {
        notTaken = 1,
        taken = 2,
        solved = 3,
        submitted = 4,
        approved = 5, 
        declined = 6, 
        dropped = 7, 
        disabled = 8
    }
}
