using Cpt206.SqlServer;
namespace FirstWebAPP
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages(); //add Razor Pages services to the application
            services.AddNorthwindContext(); //add database context
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment()) //check if the environment is not development
            {
                app.UseHsts(); //use HSTS in production environment
            }

            app.UseRouting();//use routing for the application
            app.UseHttpsRedirection();//redirect HTTP requests to HTTPS
            app.UseDefaultFiles(); //use html files in wwwroot folder
            app.UseStaticFiles(); //use static files in wwwroot folder

            // Map Razor Pages and a simple GET endpoint
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages(); //set 
                endpoints.MapGet("/hello", () => "Hello World!");
               
            });

        }
    }
}
