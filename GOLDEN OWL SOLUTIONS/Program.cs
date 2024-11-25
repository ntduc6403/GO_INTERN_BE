using GOLDEN_OWL_SOLUTIONS.Data;
using GOLDEN_OWL_SOLUTIONS.Impls;
using GOLDEN_OWL_SOLUTIONS.Intfs;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ScoresAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Cấu hình dịch vụ
            ConfigureServices(builder.Services, builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseCors("AllowAllOrigins");

            app.Run();
        }

        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver =
                        new Newtonsoft.Json.Serialization.DefaultContractResolver();
                });

            // Cấu hình CORS
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder => builder.AllowAnyOrigin()
                                      .AllowAnyMethod()
                                      .AllowAnyHeader());
            });

            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            // Cấu hình DbContext
            services.AddDbContext<Scores_DbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Đăng ký dịch vụ Score
            services.AddScoped<IScoresService, ScoresService>();
        }
    }
}
