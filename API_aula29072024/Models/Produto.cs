using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_aula29072024.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }
    }
}
