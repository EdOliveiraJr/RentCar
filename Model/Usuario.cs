using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Model
{
    public abstract class Usuario
    {
        protected int _cpf;
        protected string _nome;

        protected Usuario(int cpf, string nome)
        {
            _cpf = cpf;
            _nome = nome;
        }

        public virtual void Show() { }

    }
}
