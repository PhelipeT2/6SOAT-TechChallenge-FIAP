using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.Extensions
{
    public static class MigrationExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.CreateScope();

            using TechChallengeContext dbContext =
                scope.ServiceProvider.GetRequiredService<TechChallengeContext>();

            dbContext.Database.Migrate();
        }
    }
}
