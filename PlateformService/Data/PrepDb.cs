using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
        }

        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any())
            {
                context.AddRange(
                    new Platform() { Name = "Dot net", Publisher = "Microsoft", Cost = "Free"}, 
                    new Platform() { Name = "SQL Server", Publisher = "Microsoft", Cost = "Free"}, 
                    new Platform() { Name = "Docker", Publisher = "Microsoft", Cost = "Free"}, 
                    new Platform() { Name = "Kebernetes", Publisher = "Cloud Native Coumputing Foundation", Cost = "Free"}
                );
                context.SaveChanges();
            }
            else
            {

            }
        }
    }
}
