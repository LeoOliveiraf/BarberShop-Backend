using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BarberShop.Model
{
    [Table("Barbearias")]
    public class Barbearia
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Telefone { get; set; }
        [JsonIgnore]
        public Administrador? Administrador { get; set; }
        [Required]
        public int AdministradorId { get; set; }
        [JsonIgnore]
        public ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();
    }
}
