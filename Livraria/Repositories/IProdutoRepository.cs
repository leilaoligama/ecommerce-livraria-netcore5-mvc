using Livraria.Models;
using System.Collections.Generic;
using static Livraria.Repositories.ProdutoRepository;

namespace Livraria.Repositories
{
    public interface IProdutoRepository
    {
        void SaveProdutos(List<Livro> livros);
        IList<Produto> GetProdutos();
    }
}