using EventTest.Repositories;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddScoped<IEventRepository, EventRepository>();
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}