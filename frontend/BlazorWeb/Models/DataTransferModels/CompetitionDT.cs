namespace BlazorWeb.Models.DataTransferModels
{
    public class CompetitionDT
    {
        public int? Id { get; set; }
        public string Name { get; set; } = null!;
        public TimeSpan Duration { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int NumberConcTasks { get; set; }
        public string Hashtag { get; set; } = null!;
        public string State { get; set; }
        public string Status { get; set; }
    }
}
