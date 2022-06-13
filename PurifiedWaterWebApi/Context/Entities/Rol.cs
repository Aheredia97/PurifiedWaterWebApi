using System.ComponentModel.DataAnnotations;

namespace PurifiedWaterWebApi.Context.Entities
{
    public class Rol
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Descr { get; set; }
    }
}
