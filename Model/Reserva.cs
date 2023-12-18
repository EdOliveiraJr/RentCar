using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Model
{
    public class Reserva
    {
        private int _id;
        private Cliente? _cliente;
        private Veiculo? _veiculo;
        private int _devolucao;
        private Pagamento? _pagamento;

        public Reserva(int id, Cliente? cliente, Veiculo? veiculo, int devolucao, Pagamento? pagamento)
        {
            _id = id;
            _cliente = cliente;
            _veiculo = veiculo;
            _devolucao = devolucao;
            _pagamento = pagamento;
        }

        public void Show()
        {
            Console.WriteLine($"" +
               $"Reserva:\n" +
               $"=====================================\n"+
               $"\nDevolução: {_devolucao}\n");

            _cliente?.Show();
            _veiculo?.Show();
            _pagamento?.Show();
            Console.WriteLine("=====================================\n");
        }
    }
}
