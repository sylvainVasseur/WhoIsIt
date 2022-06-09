using BackWhoIsIt.Config;
using BackWhoIsIt.Services;

var builder = WebApplication.CreateBuilder(args);

// Configure DB
builder.Services.Configure<WhoIsItDatabaseSettings>(
    builder.Configuration.GetSection("WhoIsItDatabaseSettings"));


builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddSingleton<IPersonnageService, PersonnageService>();
builder.Services.AddSingleton<QuestionReponseService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("EnableCORS", builder =>
    {
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("EnableCORS");
app.UseAuthorization();

app.MapControllers();

app.Run();
