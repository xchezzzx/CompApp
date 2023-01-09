﻿using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.CloudServiceModels
{
    public partial class Uihistory
    {
        public Guid Id { get; set; }
        public DateTime CompletionTime { get; set; }
        public int TaskType { get; set; }
        public int RecordType { get; set; }
        public Guid Serverid { get; set; }
        public Guid Agentid { get; set; }
        public Guid Databaseid { get; set; }
        public Guid SyncgroupId { get; set; }
        public string DetailEnumId { get; set; } = null!;
        public string? DetailStringParameters { get; set; }
        public bool? IsWritable { get; set; }
    }
}
