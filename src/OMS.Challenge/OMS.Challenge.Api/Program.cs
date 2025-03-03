using OMS.Challenge.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

//TODO: 5. A penetration test has been conducted and we must remove the kestrel server header.
builder.WebHost.ConfigureKestrel(_ => { });

builder.Services.ConfigureServices();

var app = builder.Build();
app.Configure(app.Environment);

app.Services.RunMigrations();

app.Run();

