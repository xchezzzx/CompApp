namespace BlazorWeb.Models.DataTransferModels
{
    public class CompetitionDT
    {
        public int Id { get; set; }
        public string CompetitionName { get; set; } = null!;
        public string Duration { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int NumberConcTasks { get; set; }
        public string Hashtag { get; set; } = null!;

        public CompetitionDT()
        {
        }
    }
}
