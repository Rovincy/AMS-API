using DCI_TSP_API.Helpers;
using DCI_TSP_API.RxModels;
using DCI_TSP_API.TpaDataModel;
using DCI_TSP_API.UserModels;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var DefaultConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var TpaConnectionString = builder.Configuration.GetConnectionString("TpaConnection");
var UserDbConnection = builder.Configuration.GetConnectionString("UserDbConnection");
var RxDbConnection = builder.Configuration.GetConnectionString("RxDBConnectionString");
var mySqlVersion = new MySqlServerVersion(new Version(8, 0, 23)); // Adjust version as needed

builder.Services.AddDbContext<AfsContext>(options => options.UseMySql(DefaultConnectionString, mySqlVersion));
builder.Services.AddDbContext<TpaDbContext>(options => options.UseMySql(TpaConnectionString, mySqlVersion));
builder.Services.AddDbContext<AfsUserdbContext>(options => options.UseMySql(UserDbConnection, mySqlVersion));

// Specify the MySQL ServerVersion for UseMySql
builder.Services.AddDbContext<RxDBContext>(options => options.UseMySql(RxDbConnection, mySqlVersion));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(AutoMappers).Assembly);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builderIn =>
    {
        builderIn.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    }
    );
}
);
var app = builder.Build();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
