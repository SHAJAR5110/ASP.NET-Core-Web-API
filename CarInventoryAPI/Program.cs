var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();  // 👈 Important for Controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization(); // 👈 If using authentication

app.MapControllers();  // 👈 Required to map API Controllers

app.Run("http://0.0.0.0:5000");
