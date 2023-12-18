using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Enum;

namespace RentCar.Model
{
    public class Pagamento
    {
        public int _id { get; private set; }
        private double _valor;
        public StatusPagamento status { get; private set; }


        public Pagamento(int id, double valor)
        {
            _id = id;
            _valor = valor;
            status = StatusPagamento.Pendente;
        }

        internal void Show()
        {
            Console.WriteLine($"Pagamento:\n" +
                $"ID: {_id}\n" +
                $"Valor: {_valor}\n" +
                $"Status: {status}\n");
        }

        public void EfetuarPagamento(double dinheiro)
        {
            if (dinheiro >= _valor) 
            {
                status = StatusPagamento.Confirmado;
                Console.WriteLine($"Pagamento {_id} efetuado com sucesso");
            }
            else {
                Console.WriteLine($"Pagamento não efetuado. Dinheiro {dinheiro} menor do que o valor {_valor} ");
            }
            
        }
    }


}