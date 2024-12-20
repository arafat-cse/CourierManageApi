//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();




//var builder = WebApplication.CreateBuilder(args);

// CORS = cross origin request
//var Policy1 = "Policy1";
/*builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy1",
        policy =>
        {
            policy.WithOrigins("http://localhost:5041")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});*/
/*builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Policy1,
    builder =>
    {
        builder.WithOrigins("http://localhost:5041")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});*/

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: Policy1,
//      configurePolicy: policy =>
//      {
//          policy.WithOrigins("http://localhost:5041");
//      });
//});

// Add services to the container.

//builder.Services.AddControllers();

//builder.Services.AddEndpointsApiExplorer();

//var app = builder.Build();

//app.UseHttpsRedirection();
//app.UseStaticFiles();
//app.UseRouting();

//app.UseCors(Policy1);

//app.UseAuthorization();

//app.MapControllers();

//app.Run();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Define a CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("Policy1", policy =>
    {
        policy.AllowAnyOrigin()        // Allows any origin to access the API
              .AllowAnyMethod()        // Allows any HTTP method (GET, POST, etc.)
              .AllowAnyHeader();       // Allows any headers in the requests
    });
});

var app = builder.Build();

// Use CORS policy globally (for all endpoints)
app.UseCors("Policy1");

app.MapControllers();

app.Run();
