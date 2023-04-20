using Livraria.Data;
using Livraria.Models;
using Livraria.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static Livraria.Repositories.ProdutoRepository;

namespace Livraria
{
    class DataService : IDataService
    {
        protected readonly ApplicationContext contexto;
        protected readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto,
            IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public async Task InicializaDB()
        {
            await contexto.Database.MigrateAsync();

            List<Livro> livros = await GetLivros();

             produtoRepository.SaveProdutos(livros);
        }

        private static async Task<List<Livro>> GetLivros()
        {
            var json = await File.ReadAllTextAsync("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}
