using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.Services.MenuItemServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRestaurantService, RestaurantService>(); //service registration
builder.Services.AddScoped<IMenuItemService, MenuItemService>();
//adding CORS config (cross origin resource sharing) - used in frontend integration?
builder.Services.AddCors(options => 
    options.AddPolicy("fronend", policy =>
        policy.withOrigins("http://loalhost:3000")  //we can also say (*) -to say accept anything not a specific port
            .AllowAnyHeader()
            .AllowAnyMethod())
            //we can alo add using ,  for accepting multiple ports
            );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("frontend"); //ie policy name = fronend

app.MapControllers();

app.Run();
