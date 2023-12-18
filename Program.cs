using System.Reflection.Metadata;
using RentCar.Enum;
using RentCar.Model;

namespace RentCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("hello, world!");

            Funcionario func = new Funcionario( 123456789 , "Joao", 0001, Cargo.Atendente);
            func.Show();
            Cliente cli = new Cliente(00000000000, "Mauricio", "Rua rua", "41999999999");
            cli.Show();
            Veiculo veic = new Veiculo("oif0855", "Factor125", "Yamaha", 2012);
            veic.Show();
            Pagamento pag = new Pagamento(1,100.0);
            pag.Show();
            Reserva res = new Reserva(1,cli,veic,3,pag);
            res.Show();
            cli.Pagar(50.0, pag);
            cli.Pagar(100.0, pag);

        }
    }
}
