using ASPNETCore.Hubs;
using ASPNETCore.Interfaces;
using ASPNETCore.Models.DBModels;
using ASPNETCore.Repositories;
using ASPNETCore.Helpers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSignalR();

string DB_CONNECTION_STRING =
    "Server=tcp:ccmsdbserver.database.windows.net,1433;" +
    "Initial Catalog=ccms;" +
    "Persist Security Info=False;" +
    "User ID=ccmsadmin;" +
    "Password=Q!w2e3r4t5;" +
    "MultipleActiveResultSets=False;" +
    "Encrypt=True;" +
    "TrustServerCertificate=False;" +
    "Connection Timeout=30;" +
    "Encrypt=False";

builder.Services.AddDbContext<CCMSContext>(options => options.UseSqlServer(DB_CONNECTION_STRING));

builder.Services.AddCors(c => c.AddPolicy("policy", a => a.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

builder.Services.AddTransient<ICompetition, CompetitionRepository>();



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<CCMSContext>();

    SQLHelper.OpenConnection(context);
}

app.UseCors("policy");

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHub<CompetitionHub>("/competitions");

app.Run();