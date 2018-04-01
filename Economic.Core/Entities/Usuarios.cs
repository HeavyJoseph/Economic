
namespace Economic.Core.Entities
{
    public class Usuarios : BaseEntity
    {
        public int EntidadId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Enable { get; set; }
    }
}
