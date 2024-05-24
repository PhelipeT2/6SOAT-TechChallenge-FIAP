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
        public virtual async Task<Pedido> Atualizar(Pedido pedido)
        {
            var entry = _context.Entry(pedido);

            _context.Pedido.Update(entry.Entity);

            await _context.SaveChangesAsync();

            return pedido;
        }

        public async Task<List<Pedido>> ListarPedidos() => await _context.Pedido.Include(x => x.Cliente).Include(x=> x.Produtos).ThenInclude(x => x.Produto).ToListAsync();
        public async Task<Pedido> ObterPorId(long id) => await _context.Pedido.Include(x => x.Cliente).Include(x => x.Produtos).ThenInclude(x => x.Produto).FirstOrDefaultAsync(x => x.Id == id);

    }
}
