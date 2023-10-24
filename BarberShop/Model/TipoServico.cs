using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BarberShop.Model
{
    public class TipoServico
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int Duracao { get; set; }
        [Required]
        public double Valor { get; set; }
        [JsonIgnore]
        public ICollection<Agendamento> Agendamentos { get; } = new List<Agendamento>();
    }
}
