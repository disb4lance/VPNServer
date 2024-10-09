using Repository;

namespace VPN_Management.Extensions
{
    public static class ServiceExtentions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddSqlServer<RepositoryContext>(configuration.GetConnectionString("sqlConnection"));
    }
}
