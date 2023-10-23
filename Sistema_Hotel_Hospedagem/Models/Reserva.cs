using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hotel_Hospedagem.Models
{
    public class Reserva
    {
        public Reserva()
        {
            
        }
        public Reserva(int _diasReservados)
        {
            DiasReservados = _diasReservados;
        }
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public decimal DiasReservados { get; set; }

       public void CadastrarHospedes(List<Pessoa> hospedes, int capacidade) 
        {
            Suite.Capacidade = capacidade;

            foreach (var item in hospedes)
            {
                Hospedes.Add(item);
            }
        }

        public void CadastrarSuite(Suite suite) 
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int quantidade = Hospedes.Count;
            return quantidade;
        }

        public decimal CalcularValorDiaria(decimal dias) 
        {
            DiasReservados += dias;

            if (DiasReservados >= 10)
            {
                DiasReservados = (DiasReservados * Suite.ValorDiaria) - 10;
                Console.WriteLine($"Total a pagar: {DiasReservados:C}");
                return DiasReservados;
            }
            else
            {
                DiasReservados = DiasReservados * Suite.ValorDiaria;
                Console.WriteLine($"Total a pagar: {DiasReservados:C}");
                return DiasReservados;

            }
        }
    }
}
