﻿using System;
using System.Collections.Generic;

namespace ASPNETCore.Models.CloudServiceModels
{
    public partial class Agent
    {
        public Agent()
        {
            AgentInstances = new HashSet<AgentInstance>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? Subscriptionid { get; set; }
        public int? State { get; set; }
        public DateTime? Lastalivetime { get; set; }
        public bool IsOnPremise { get; set; }
        public string? Version { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }

        public virtual Subscription? Subscription { get; set; }
        public virtual ICollection<AgentInstance> AgentInstances { get; set; }
    }
}
