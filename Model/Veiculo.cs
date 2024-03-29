﻿using RentCar.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Model
{
    public class Veiculo
    {
        private string _placa;
        private string _modelo;
        private string _marca;
        private int _ano;
        private StatusVeiculo _status { get; set; }

        public Veiculo(string placa, string modelo, string marca, int ano)
        {
            _placa = placa;
            _modelo = modelo;
            _marca = marca;
            _ano = ano;
            _status = StatusVeiculo.Livre;
        }

        public virtual void Show()
        {
            Console.WriteLine($"" +
                $"Veículo:" +
                $"\nPlaca: {_placa}" +
                $"\nModelo: {_modelo}" +
                $"\nMarca: {_marca}" +
                $"\nAno: {_ano}" +
                $"\nStatus: {_status}\n");

        }

    }
}