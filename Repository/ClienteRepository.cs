using RentCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Repository
{
    internal static class ClienteRepository
    {
        private static List<Cliente> _clientes = new List<Cliente>();
        public static void AdicionarCliente(Cliente cliente)
        {
            _clientes.Add(cliente);
            Console.WriteLine($"Clente {0}, criado com sucesso");
            cliente.Show();
        }

        public static void MostraClientes()
        {
            Console.WriteLine("Lista de Clientes");
            Console.WriteLine("=====================================\n");
            foreach (var cliente in _clientes)
            {
                cliente.Show();
               
            }
            Console.WriteLine("=====================================\n");
        }
    }


}
