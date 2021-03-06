using System.Net.Mail;
using LoanstepCore.Integration;
using LoanstepCore.Services;
using LoanstepIntegration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Integrations
builder.Services.Add(new ServiceDescriptor(typeof(ICreditReportClient), c => new BisnodeReportClient( "Token"), ServiceLifetime.Transient));
builder.Services.Add(new ServiceDescriptor(typeof(IEmailClient), c => new SMTPEmailClient( "smtp.google.com", 557, "noreply@loanstep.se", "password"), ServiceLifetime.Transient));

builder.Services.AddSingleton<CreditReportService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();