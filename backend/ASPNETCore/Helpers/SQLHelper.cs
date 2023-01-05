using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Helpers
{
    public class SQLHelper
    {
        public static void OpenConnection(CCMSContext context)
        {

                context.CompetitionStatuses.AddRange(CompetitionStatuses.Select(u => u.Value).ToList());
            
                context.Competitions.AddRange(Competitions.Select(u => u.Value).ToList());

        }

        public static Dictionary<int, Competition> _competition;

        public static Dictionary<int, CompetitionStatus> _competitionStatus;

        public static Dictionary<int, Competition> Competitions {
            get
            {
                if (_competition == null)
                {
                    //var list = new Competition[]
                    //{
                    //    new Competition
                    //    {
                    //        Id = 1003,
                    //        CompetitionName = "Hakaton",
                    //        Duration = new TimeSpan(0),
                    //        StartTime = DateTime.Now,
                    //        EndTime = DateTime.Now,
                    //        NumberConcTasks = 10,
                    //        Hashtag = "#Hakaton",
                    //        DateCreate = DateTime.Now,
                    //        DateUpdate = DateTime.Now,
                    //        UserCreateId = 1,
                    //        UserUpdateId = 1,
                    //        StatusId = 1,
                    //        Status = new CompetitionStatus(){Id = 1, CompetitionStatusName = "Current"}

                    //    },
                    //    new Competition
                    //    {
                    //        Id = 1005,
                    //        CompetitionName = "Hakaton",
                    //        Duration = new TimeSpan(0),
                    //        StartTime = DateTime.Now,
                    //        EndTime = DateTime.Now,
                    //        NumberConcTasks = 10,
                    //        Hashtag = "#Hakaton",
                    //        DateCreate = DateTime.Now,
                    //        DateUpdate = DateTime.Now,
                    //        UserCreateId = 1,
                    //        UserUpdateId = 1,
                    //        StatusId = 1,
                    //        Status = new CompetitionStatus(){Id = 1, CompetitionStatusName = "Future"}
                    //    }

                    //};

                    _competition = new Dictionary<int, Competition>();

                    //foreach (var c in list)
                    //{
                    //    _competition.Add(c.Id, c); 
                    //}
                }
                return _competition;
            }
        }

        public static Dictionary<int, CompetitionStatus> CompetitionStatuses
        {
            get
            {
                if (_competitionStatus == null)
                {
                    //var list = new CompetitionStatus[]
                    //{
                    //    new CompetitionStatus
                    //    {
                    //        Id = 1021,
                    //        CompetitionStatusName = "Future"

                    //    },
                    //    new CompetitionStatus
                    //    {
                    //        Id = 1022,
                    //        CompetitionStatusName = "Current"

                    //    },
                    //    new CompetitionStatus
                    //    {
                    //        Id = 1023,
                    //        CompetitionStatusName = "Past"

                    //    }

                    //};

                    _competitionStatus = new Dictionary<int, CompetitionStatus>();

                    //foreach (var c in list)
                    //{
                    //    _competitionStatus.Add(c.Id, c);
                    //}
                }
                return _competitionStatus;
            }
        }

        

    }
}
