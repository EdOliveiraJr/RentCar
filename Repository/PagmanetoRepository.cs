using RentCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Repository
{
    internal static class PagamentoRepository
    {
        private static List<Pagamento> _pagamentos = new List<Pagamento> ();

        public static void AdicionarPagamento(Pagamento pagamento)
        {
            _pagamentos.Add (pagamento);
            Console.WriteLine($"Pagamento criado com sucesso");
            pagamento.Show();
        }

        public static void MostraPagamento()
        {
            Console.WriteLine("Lista de Pagamentos");
            Console.WriteLine("=====================================\n");
            foreach (var pagamento in _pagamentos)
            {
                pagamento.Show();

            }
            Console.WriteLine("=====================================\n");
        }

        public static void VerificaPagamentoById(int id)
        {
            var pagamento = _pagamentos.FirstOrDefault(p => p._id == id);
            Console.WriteLine($" O pagamento id {id} se encontra {pagamento?.status}\n");

        }
    }
}
