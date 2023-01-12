using Sample.Secrets;
using Sample.Auth.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISecretProvider, LocalSecretProvider>();


var sp = builder.Services.BuildServiceProvider();

builder.Services.AddAuthentication().AddGoogle(options => {
    var secretProvider = sp.GetService<ISecretProvider>();
    options.ClientId = secretProvider.ClientId;
    options.ClientSecret = secretProvider.ClientSecret;
});

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
