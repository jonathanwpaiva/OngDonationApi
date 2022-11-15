using OngDonationApi.Facades;
using OngDonationApi.Facades.Interfaces;
using OngDonationApi.Models.UI;
using OngDonationApi.Repositories;
using OngDonationApi.Repositories.Interfaces;
using OngDonationApi.Services.Interfaces;
using RestEase;

var builder = WebApplication.CreateBuilder(args);

var apiSettings = builder.Configuration.GetSection("apiSettings").Get<ApiSettings>();


// Add services to the container.
builder.Services.AddSingleton(apiSettings);
builder.Services.AddSingleton(RestClient.For<ICnpjService>(apiSettings.BrasilApiBaseUrl));
builder.Services.AddSingleton(RestClient.For<ICepService>(apiSettings.BrasilApiBaseUrl));
builder.Services.AddSingleton<ICepFacade, CepFacade>();
builder.Services.AddSingleton<ICnpjFacade, CnpjFacade>();
builder.Services.AddSingleton<IOngsRepository, OngsRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
