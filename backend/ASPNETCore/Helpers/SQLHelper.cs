using ASPNETCore.Models.DBModels;

namespace ASPNETCore.Helpers
{
    public static class SQLHelper
    {
        public static void OpenConnection(CCMSContext context)
        {

            //context.CompetitionStatuses.Add(new CompetitionStatus() { CompetitionStatusName = "asdaas"});

            Competition competition = new Competition()
            {
                CompetitionName = "CompetitionName",
                DateCreate = DateTime.Now,
                DateUpdate = DateTime.Now,
                EndTime = DateTime.Now.AddDays(1),
                StartTime = DateTime.Now,
                Duration = DateTime.Now.AddDays(1) - DateTime.Now,
                Hashtag = "Hashtag",
                NumberConcTasks = 3,
                //Status= comps[0].Status,
                StatusId = 1,
                UserCreateId = 1,
                UserUpdateId = 1
            };

            context.Competitions.Add(competition);

            context.SaveChanges();
        }

        public static Dictionary<int, Competition> _competition;

        public static Dictionary<int, CompetitionStatus> _competitionStatus;

        public static Dictionary<int, Competition> Competitions
        {
            get
            {
                var context = new CCMSContext();
                var comps = context.Competitions.ToList();
                _competition ??= new Dictionary<int, Competition>()
                {
                    { 0, new Competition()
                    {
                        CompetitionName = comps[0].CompetitionName,
                        DateCreate= DateTime.Now,
                        DateUpdate= DateTime.Now,
                        EndTime= DateTime.Now.AddDays(1),
                        StartTime = DateTime.Now,
                        Duration = comps[0].Duration,
                        Hashtag= comps[0].Hashtag,
                        NumberConcTasks= comps[0].NumberConcTasks,
                        //Status= comps[0].Status,
                        StatusId= comps[0].StatusId,
                        UserCreateId= comps[0].UserCreateId,
                        UserUpdateId= comps[0].UserUpdateId
                    }
                    }
                };
                _competition[0].Id = 10000;
                return _competition;
            }
        }

        public static Dictionary<int, CompetitionStatus> CompetitionStatuses
        {
            get
            {
                _competitionStatus ??= new Dictionary<int, CompetitionStatus>();
                return _competitionStatus;
            }
        }



    }
}
