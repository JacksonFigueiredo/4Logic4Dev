using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Domain.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeContato { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCliente { get; set; }
        public CategoriaCliente Categoria { get; set; }
        public virtual ICollection<Avaliacao> Avaliacoes { get; set; } = new List<Avaliacao>();
    }

}
