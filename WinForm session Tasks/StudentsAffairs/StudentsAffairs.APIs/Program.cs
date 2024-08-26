


namespace StudentsAffairs.APIs;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        #region Services Configuration
        builder.Services.AddControllers();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAllOrigins",
                policy =>
                {
                    policy.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod();
                });
        });


        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<ApplicationContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });

        builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped<IStudentService, StudentService>();
        builder.Services.AddAutoMapper(typeof(MappingProfiles));

        #endregion

        var app = builder.Build();

        #region Database Migration

        using var scope = app.Services.CreateScope();
        var services = scope.ServiceProvider;
        var _dbContect = services.GetRequiredService<ApplicationContext>();
        var loggerFactory = services.GetRequiredService<ILoggerFactory>();
        try
        {
            await _dbContect.Database.MigrateAsync();
            await ApplicationDataSeed.SeedDataAsync(_dbContect);
        }
        catch (Exception ex)
        {
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogError(ex, "An error occurred while migrating the database.");
        }
        #endregion

        #region Kestrel Configuration

        // Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
        app.UseSwagger();
        app.UseSwaggerUI();
        //}

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        #endregion
        await app.RunAsync();
    }
}
