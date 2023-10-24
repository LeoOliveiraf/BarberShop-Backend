
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace BarberShop.Model
{
    public class Agendamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public DateTime Data { get; set; }
   
        public int TipoServicoId { get; set; }
        [JsonIgnore]
        public TipoServico TipoServico { get; set; } = null!;

        public int ClienteId { get; set; }
        [JsonIgnore]
        public Cliente Cliente { get; set; } = null!;
        
        public int BarbeariaId { get; set; }
        [JsonIgnore]
        public Barbearia Barbearia { get; set; } = null!;



    }
}
