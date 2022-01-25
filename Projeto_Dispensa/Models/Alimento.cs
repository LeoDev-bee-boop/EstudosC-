using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Alimento
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public DateTime Validade { get; set; }
        public string Tamanho { get; set; }
    }
}
