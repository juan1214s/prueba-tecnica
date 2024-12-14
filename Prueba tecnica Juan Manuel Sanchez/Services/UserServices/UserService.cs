using Prueba_tecnica_Juan_Manuel_Sanchez.Db;
using Prueba_tecnica_Juan_Manuel_Sanchez.Models.UserModel;

namespace Prueba_tecnica_Juan_Manuel_Sanchez.Services.UserServices
{
    public class UserService
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<UserService> _logger;

        public UserService(AppDbContext dbContext, ILogger<UserService> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<CreateUserModel> CreateUserAsync(CreateUserModel userModel)
        {
            if (userModel == null)
            {
                _logger.LogError("El modelo de usuario es nulo.");
                throw new ArgumentNullException(nameof(userModel));
            }

            try
            {
                _dbContext.UserModel.Add(userModel);
                await _dbContext.SaveChangesAsync();

                _logger.LogInformation($"Bienvenido a nuestra app: {userModel.Name} y {userModel.Id}");
                return userModel;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al crear el usuario: {ex.Message}");
                throw;
            }
        }
    }
}
