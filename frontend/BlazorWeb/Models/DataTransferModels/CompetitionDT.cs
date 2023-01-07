namespace BlazorWeb.Models.DataTransferModels
{
    public class CompetitionDT
    {

        public int? Id { get; set; }
        public string CompetitionName { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int NumberConcTasks { get; set; }
        public string Hashtag { get; set; } = null!;

        public CompetitionDT()
        {
        }

    }
}
