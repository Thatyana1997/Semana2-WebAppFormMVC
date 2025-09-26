using System.ComponentModel.DataAnnotations;

namespace WebAppFormMVC.Models
{
    public class ContactMessages
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electronico es obligatorio")]
        [EmailAddress(ErrorMessage = "Formato de correo no valido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio")]
        [StringLength(500, ErrorMessage = "El mensaje no puede superar los 500 caracteres")] 
        public string Mensaje { get; set; }
    }
}
