﻿namespace BlazorWeb.Models.DataTransferModels
{
	public class TaskDT
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string Content { get; set; } = null!;
		public int CategoryId { get; set; }
		public int LangId { get; set; }
		public int PlatformId { get; set; }
		public int Timeframe { get; set; }
		public int Points { get; set; }
		public int Fine { get; set; }
		public bool IfHasBonus { get; set; }
		public string? BonusContent { get; set; }
		public int? BonusTimeframe { get; set; }
		public int? BonusPoints { get; set; }
		public DateTime CreateDate { get; set; }
		public int CreateUserId { get; set; }
		public DateTime UpdateDate { get; set; }
		public int UpdateUserId { get; set; }
		public int StatusId { get; set; }
	}
}
