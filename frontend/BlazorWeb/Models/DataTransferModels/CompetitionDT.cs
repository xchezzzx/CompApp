﻿using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models.DataTransferModels
{
    public class CompetitionDT
    {
        public int? Id { get; set; }
        [Required]
		public string Name { get; set; } = null!;
        public TimeSpan Duration { get; set; }

        [Required]
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int NumberConcTasks { get; set; }
        [Required]
		public string Hashtag { get; set; } = null!;
        public string State { get; set; }
        public string Status { get; set; }
    }
}
