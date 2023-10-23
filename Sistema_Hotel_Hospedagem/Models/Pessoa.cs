using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hotel_Hospedagem.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string _nomeCompleto)
        {
            NomeComplete = _nomeCompleto;
        }
        public string NomeComplete { get; set; }
    }
}
