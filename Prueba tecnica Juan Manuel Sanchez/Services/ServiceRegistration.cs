using Prueba_tecnica_Juan_Manuel_Sanchez.Services.UserServices;


namespace Prueba_tecnica_Juan_Manuel_Sanchez.Services
{
    public static class ServiceRegistration
    {
        public static void AddCustomService(this IServiceCollection services)
        {
            services.AddScoped<UserService>();
        }
    }
}
