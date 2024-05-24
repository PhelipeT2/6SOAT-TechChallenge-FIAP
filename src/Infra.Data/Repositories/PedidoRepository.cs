using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly TechChallengeContext _context;
        public PedidoRepository(TechChallengeContext context)
        {
            _context = context;
        }

        public async Task<Pedido> Inserir(Pedido pedido)
        {
            if (pedido is null)
            {
                throw new ArgumentNullException(nameof(pedido));
            }

            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task<List<Pedido>> ListarPedidos()
        {
            return await _context.Pedido.Include(x=> x.Produtos).ToListAsync();
        }
    }
}
