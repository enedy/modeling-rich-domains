using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NerdStore.Vendas.Application.Queries.DTO;

namespace NerdStore.Vendas.Application.Queries
{
    public interface IPedidoQueries
    {
        Task<CarrinhoDTO> ObterCarrinhoCliente(Guid clienteId);
        Task<IEnumerable<PedidoDTO>> ObterPedidosCliente(Guid clienteId);
    }
}