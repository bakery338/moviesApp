namespace MovieApp.Api.configaration
{
    public static class DenpendecyInjecation
    {
        public static IServiceCollection AddApiServices(this IServiceCollection service, IConfiguration configuration)
        {
            return service;
        }
    }
}
