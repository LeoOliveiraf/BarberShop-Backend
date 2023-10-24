using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BarberShop.Model
{
    public class Cliente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [JsonIgnore]
        public ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();

    }
}
