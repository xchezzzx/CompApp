using ASPNETCore.Models.DTModels;
using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Helpers
{
    public class ToDBModelsParsers
    {
        public static Competition CompetitionParser(CompetitionDT competitionDT) 
        {

            return new Competition()
            {
                CompetitionName = competitionDT.CompetitionName,
                StartTime = competitionDT.StartTime,
                Duration = competitionDT.Duration,
                EndTime = competitionDT.EndTime,
                NumberConcTasks = competitionDT.NumberConcTasks,
                Hashtag = competitionDT.Hashtag,
                DateCreate = DateTime.Now,
                DateUpdate = DateTime.Now,
                UserCreateId = 1,
                UserUpdateId = 1,
                StatusId = 1
            };

        }
    }
}
