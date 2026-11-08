namespace cibertec_demo.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres")]
        [Display(Name = "Nombre completo")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [StringLength(50, ErrorMessage = "El correo no puede superar los 50 caracteres")]
        [EmailAddress(ErrorMessage = "Correo electrónico inválido")]
        [Display(Name = "Correo electrónico")]
        public string correo { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "La contraseña debe tener entre 4 y 50 caracteres")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string contraseña { get; set; }
    }
}
