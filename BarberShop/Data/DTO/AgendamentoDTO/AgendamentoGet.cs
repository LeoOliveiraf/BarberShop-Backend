﻿namespace BarberShop.Data.DTO.AgendamentoInputModelBarbearia
{
    public class AgendamentoGet
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public String TipoServicoNome { get; set; }
        public String ClienteNome { get; set; }
    }
}
