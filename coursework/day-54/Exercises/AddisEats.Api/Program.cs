using AddisEats.Api.Services.ClockServices; //ex-3
using AddisEats.Api.Services.PaymentServices; //ex-5
using AddisEats.Api.Options; //ex-6
using AddisEats.Api.Authentication; //ex-8
using Microsoft.AspNetCore.Authentication; //

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IClock, Clock>(); //ex-3     //ex-7 : try deliberately remove temporarily
//builder.Services.AddTransient<IClock, SystemClock>(); //ex-4 try
//builder.Services.AddSingleton<IClock, SystemClock>(); //try
builder.Services.AddScoped<IPaymentProvider, TeleBirrProvider>(); //ex-5
// builder.Services.AddScoped<IPaymentProvider, TeleBirrProvider>(); //try instead
builder.Services.Configure<DeliveryOptions>(                    //ex-6
    builder.Configuration.GetSection("Delivery"));
builder.Services.AddAuthentication("Demo")                  //ex-8
    .AddScheme<AuthenticationSchemeOptions, DemoAuthenticationHandler>(
        "Demo", options => { });

builder.Services.AddAuthorization();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication(); 

app.UseAuthorization();

app.MapControllers();

app.Run();
