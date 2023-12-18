using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Model
{
    public class Cliente : Usuario
    {
        private string _endereco;
        private string _telefone;

        public Cliente(int cpf, string nome, string endereco, string telefone) : base(cpf, nome)
        {
            _endereco = endereco;
            _telefone = telefone;
        }

        public void Pagar(double dinheiro, Pagamento pagamento)
        {
            pagamento.EfetuarPagamento(dinheiro);
        }

        public override void Show()
        {
            Console.WriteLine($"" +
                $"Cliente:" +
                $"\nNome: {_nome}" +
                $"\nCpf: {_cpf}" +
                $"\nEndereço: {_endereco}" +
                $"\nTelefone: {_telefone}\n");

        }
    }
}
