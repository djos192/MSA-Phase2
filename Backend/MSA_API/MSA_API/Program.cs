var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();
builder.Services.AddSwaggerGen();

app.UseSwagger(options =>
{
    options.SerializeAsV2 = true;
});

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});

builder.Services.AddSwaggerDocument(options =>
{
    options.DocumentName = "DJs API";
    options.Version = "V1";
});
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())

{
    app.UseDeveloperExceptionPage();
    app.UseOpenApi();
    app.UseSwaggerUi3();
}


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();





