using Livraria.Models;
using System.Threading.Tasks;

namespace Livraria.Repositories
{
    public interface IPedidoRepository
    {
        Task<Pedido> GetPedido();
        Task AddItem(string codigo);
    }
}
