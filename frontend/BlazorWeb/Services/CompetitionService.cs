﻿using BlazorWeb.Interfaces;
using BlazorWeb.Models.DataTransferModels;
using Microsoft.AspNetCore.SignalR.Client;
using System.ComponentModel;

namespace BlazorWeb.Services
{
    public class CompetitionService : ICompetitionService
    {
        public CompetitionService()
        {
            
        }


        public Task AddCompetition(CompetitionDT competitionDT)
        {
            throw new NotImplementedException();
        }

        private List<CompetitionDT> _getAllCompetitions { get; set; }

        public async Task<List<CompetitionDT>> GetAllCompetitionsAsync()
        {
            if (_getAllCompetitions == null)
            {
                HubConnection HubConnection = new HubConnectionBuilder()
                    .WithUrl("https://localhost:7206/competitions")
                    .Build();

                HubConnection.On<List<CompetitionDT>>("Send", c => _getAllCompetitions = c);

                await HubConnection.StartAsync();
                await HubConnection.InvokeAsync("SendGenericCompetitions", "State", "Status");
                await HubConnection.StopAsync();
            }
            return _getAllCompetitions;
        }

    }
    
}
