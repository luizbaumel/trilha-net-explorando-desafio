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
            if (hospedes.Count <= this.Suite.Capacidade)
                Hospedes = hospedes;
            else
                throw new Exception("A quantidade de hospedes é maior do que a capacidade da suite."); 
        }

        public void CadastrarSuite(Suite suite)
            => Suite = suite;

        public int ObterQuantidadeHospedes()
            => this.Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valorTotal -= valorTotal / 10;

            return valorTotal;
        }
    }
}