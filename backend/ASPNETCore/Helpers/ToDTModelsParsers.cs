using ASPNETCore.Models.DBModels;
using ASPNETCore.Models.DTModels;

namespace ASPNETCore.Helpers
{
    public class ToDTModelsParsers
    {
        public static CompetitionDT DTCompetitionParser(Competition competition)
        {

            return new CompetitionDT()
            {
                Id = competition.Id,
                CompetitionName = competition.CompetitionName,
                StartTime = competition.StartTime,
                Duration = competition.Duration,
                EndTime = competition.EndTime,
                NumberConcTasks = competition.NumberConcTasks,
                Hashtag = competition.Hashtag,
            };

        }
    }
}
