﻿using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models.DataTransferModels
{
	public class TeamDT
	{
		public int? Id { get; set; }

		[Required, Display(Name = "team name")]
		public string Name { get; set; } = null!;
		public byte[]? Icon { get; set; }
		public int? SumPoints { get; set; }
		public DateTime CreateDate { get; set; }
		public int CreateUserId { get; set; }
		public DateTime UpdateDate { get; set; }
		public int UpdateUserId { get; set; }
		public int StatusId { get; set; }
	}
}
