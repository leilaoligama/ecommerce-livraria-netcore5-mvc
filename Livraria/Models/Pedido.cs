﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Livraria.Models
{
    public class Pedido : BaseModel
    {
        public int CadastroId { get; set; }

        public Pedido()
        {
            Cadastro = new Cadastro();
        }

        public Pedido(Cadastro cadastro)
        {
            Cadastro = cadastro;
        }

        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();

        [Required]
        public virtual Cadastro Cadastro { get; private set; }
    }
}
