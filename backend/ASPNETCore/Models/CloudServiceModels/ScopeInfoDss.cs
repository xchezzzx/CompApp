﻿using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.CloudServiceModels
{
    public partial class ScopeInfoDss
    {
        public int ScopeLocalId { get; set; }
        public Guid ScopeId { get; set; }
        public string SyncScopeName { get; set; } = null!;
        public byte[]? ScopeSyncKnowledge { get; set; }
        public byte[]? ScopeTombstoneCleanupKnowledge { get; set; }
        public byte[]? ScopeTimestamp { get; set; }
        public Guid? ScopeConfigId { get; set; }
        public int ScopeRestoreCount { get; set; }
        public string? ScopeUserComment { get; set; }
    }
}
