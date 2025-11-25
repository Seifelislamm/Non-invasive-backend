
namespace GlucoseMonitoringApp
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            // CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });

            // Controllers
            builder.Services.AddControllers();

           
            

            var app = builder.Build();

            app.UseCors("AllowAll");

            

            app.UseHttpsRedirection();
            app.UseAuthorization();

            // **هنا مهم جدًا**
            app.MapControllers();

            app.Run();
        }
    }
}

