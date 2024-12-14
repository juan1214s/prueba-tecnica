using System.ComponentModel.DataAnnotations;

namespace Prueba_tecnica_Juan_Manuel_Sanchez.Models.UserModel
{
    public class CreateUserModel
    {
        private static int _idCounter = 0; 

        public int Id { get; private set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El número de teléfono es obligatorio.")]
        public string Phone { get; set; }

        public CreateUserModel(string name, string phone)
        {
            Id = GenerateId(); 
            Name = name;
            Phone = phone;
        }

        private static int GenerateId()
        {
            return ++_idCounter; 
        }
    }
}
