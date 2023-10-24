using BarberShop.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace BarberShop.Data.DTO.AgendamentoInputModelBarbearia
{
    public class AgendamentoCreate
    {
        public DateTime Data { get; set; }
        public int TipoServicoId { get; set; }
        public int ClienteId { get; set; }
        public int BarbeariaId { get; set; }
    }
}
