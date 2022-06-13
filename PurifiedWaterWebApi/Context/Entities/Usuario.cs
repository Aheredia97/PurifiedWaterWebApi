using System.ComponentModel.DataAnnotations;

namespace PurifiedWaterWebApi.Context.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Nombre { get; set; }
        [MaxLength(50)]
        public string Apellido { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }

        //Nav
        public Rol Rol { get; set; }
    }
}
