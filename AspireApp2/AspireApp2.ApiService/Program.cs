var builder = WebApplication.CreateBuilder(args);

builder.AddRedisDistributedCache(connectionName: "cache");
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();
// added controller support
builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();


// added controller support
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.MapDefaultEndpoints();

app.Run();
