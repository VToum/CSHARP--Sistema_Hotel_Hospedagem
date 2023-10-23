using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hotel_Hospedagem.Models
{
    public class Suite
    {
        public Suite()
        {
            
        }
        public Suite(string _tipoSuite, int _capacidade, decimal _valorDecimal)
        {
            TipoSuite = _tipoSuite;
            Capacidade = _capacidade;
            ValorDiaria = _valorDecimal;
        }
        public string TipoSuite { get; set; }
        public int Capacidade { get; set; }
        public decimal ValorDiaria { get; set; }
    }
}
