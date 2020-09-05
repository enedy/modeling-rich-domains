using System;
using System.Collections.Generic;

namespace NerdStore.Vendas.Application.Queries.DTO
{
    public class CarrinhoDTO
    {
        public Guid PedidoId { get; set; }
        public Guid ClienteId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorDesconto { get; set; }
        public string VoucherCodigo { get; set; }

        public List<CarrinhoItemDTO> Items { get; set; } = new List<CarrinhoItemDTO>();
        public CarrinhoPagamentoDTO Pagamento { get; set; }
    }
}