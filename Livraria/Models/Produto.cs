﻿using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Produto : Base
    {
        public Produto() { }

        [Required]
        public string Codigo { get; private set; }

        [Required]
        public string Nome { get; private set; }
        
        [Required]
        public decimal Preco { get; private set; }

        public Produto(string codigo, string nome, decimal preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}
