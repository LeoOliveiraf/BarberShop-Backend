namespace BarberShop.Data.DTO.AgendamentoDTO
{
    public class AgendamentoPut
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int TipoServicoId { get; set; }
        public int ClienteId { get; set; }
        public int BarbeariaId { get; set; }
    }
}
