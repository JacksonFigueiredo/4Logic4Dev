using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Logic4Devs.Domain.Models
{
    public class AvaliacaoDTO
    {
        public int Id { get; set; }
        public DateTime DataReferencia { get; set; }
        public int Nota { get; set; }
        public string Motivo { get; set; }
        public int ClienteId { get; set; }
    }
}
