using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using RentCar.Enum;

namespace RentCar.Model
{
    public class Funcionario : Usuario
    {
        private int _matricula;
        private Cargo _cargo;
        public Funcionario(int cpf, string nome, int matricula, Cargo cargo) : base(cpf, nome)
        {
            _matricula = matricula;
            _cargo = cargo;
        }

        public override void Show()
        {
            Console.WriteLine($"" +
                $"Funcionario:" +
                $"\nNome: {_nome}" +
                $"\nCpf: {_cpf}" +
                $"\nMatrituca: {_matricula}" +
                $"\nCargo: {_cargo}\n");
        }

    }
}
