using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Domain.Models
{
    public class ClienteDTO
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string NomeContato { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataCliente { get; set; }
        public CategoriaCliente Categoria { get; set; }
    }
}
