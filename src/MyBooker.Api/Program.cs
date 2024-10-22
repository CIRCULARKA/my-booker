var builder = WebApplication.CreateBuilder(args);

var config = builder.GetAppConfiguration();

builder.Services.AddMyBookerStorage(config);
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.UseRouting();
app.Run();
