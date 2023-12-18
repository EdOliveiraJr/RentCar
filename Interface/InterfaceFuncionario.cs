using RentCar.Model;
using RentCar.Repository;
using System;

namespace RentCar.Interface
{
    internal interface InterfaceFuncionario
    {
        public static void ExibirMenuCliente()
        {

            bool sair = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Escolha uma das opções abaixo para começar:\n");


                string[] opcoesUsuario = { "1. Cadastrar Cliente", "2. Gerar Ordem de Pagamento", "3. Verificar Pagamento", "4. Criar Reserva.", "5. Sair" };

                var menuPrincipal = new ConsoleMenu<string>(opcoesUsuario);
                int selecaoUsuario = menuPrincipal.ShowMenu();
                switch (selecaoUsuario)
                {
                    case 0:
                        Console.WriteLine(opcoesUsuario[0]);
                        AdicionarCliente();
                        break;
                    case 1:
                        Console.WriteLine(opcoesUsuario[1]);
                        GerarPagamento();
                        break;
                    case 2:
                        Console.WriteLine(opcoesUsuario[2]);
                        VerificarPagamento();
                        break;
                    case 3:
                        Console.WriteLine(opcoesUsuario[3]);
                        break;
                    case 4:
                        sair = true;
                        break;
                }

                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();

            } while (!sair);
        }

        public static void AdicionarCliente()
        {
            Console.WriteLine("Digite o CPF:\n");
            int cpf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Nome:\n");
            string? nome = Console.ReadLine();
            Console.WriteLine("Digite o Endereço:\n");
            string? endereco = Console.ReadLine();
            Console.WriteLine("Digite o telefone:\n");
            string? telefone = Console.ReadLine();

            Cliente cliente = new (cpf, nome, endereco, telefone);
            ClienteRepository.AdicionarCliente(cliente);
        }

        public static void GerarPagamento()
        {
            Console.WriteLine("Digite o ID:\n");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor:\n");
            double valor = Convert.ToDouble(Console.ReadLine());

            Pagamento pagamento = new(id, valor);
            PagamentoRepository.AdicionarPagamento(pagamento);
            
        }

        public static void VerificarPagamento()
        {
            Console.WriteLine("Digite o id do pagamento:");
            int id = Convert.ToInt32(Console.ReadLine());
            PagamentoRepository.VerificaPagamentoById(id);
        }
    }
}