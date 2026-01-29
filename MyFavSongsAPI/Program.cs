using EFDatabase.EF;
using MyFavSongsAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddHttpClient<ISongService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7086/api");
});
builder.Services.AddHttpClient<IAlbumService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7086/api");
});

builder.Services.AddHttpClient<IArtistService>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7086/api");
});






var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
