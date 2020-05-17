using System;
using System.Collections.Generic;
using System.Text;

namespace Veiculo
{
    class Veiculo
    {
        private String Placa;
        private int Combustivel;

        public Veiculo()
        {

        }

        public Veiculo (int Combustivel)
        {
            this.Combustivel = Combustivel;
        }
        public void SetPlaca (string valor)
        {
            this.Placa = valor;
        }
        public string GetPlaca()
        {
            return this.Placa;
        }

        public void SetCombustivel(int Combustivel)
        {
            this.Combustivel = Combustivel;
        }
        public string GetCombustivel()
        {
            return this.Placa;
        }
    }
}
