using System.Security.Cryptography.X509Certificates;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTO!
           
            if  (Suite.Capacidade >= hospedes.Count )
            {
                Hospedes = hospedes;
            }
            else
            {
               
                // *IMPLEMENTO!
                throw new Exception("O número de hospedes não pode exceder a capaciddae da Suite.");
            }
           
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTO!
            
                return Hospedes.Count;
        }
        

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTO!
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // *IMPLEMENTO!
           
            if (DiasReservados >= 10)
            {
                valor = valor - (valor /100 * 10) ;
            }

            return valor;
        }
    }
}
