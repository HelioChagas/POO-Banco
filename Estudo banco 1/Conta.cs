using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;



namespace Estudo_banco_1
{
    class Conta
    {
        private string nomeCliente;
        private int numero;
        private int tipo;
        private double saldo;

        public Conta()
        {
            this.saldo = 0.0;
        }
        public Conta(string nomeCliente, int numero)
        {
            this.nomeCliente = nomeCliente;
            this.numero = numero;
            this.saldo = 0.0;
        }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public int Numero { get => numero; set => numero = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public double Sacar(double valor)
        {
            var resultado = saldo - valor;
            return resultado;
        }
        public double Depositar(double valor)
        {
            var resultado = saldo + valor;
            return resultado;
        }

        public void extratoConta()
        {
            MessageBox.Show("Meu saldo conta é R$ "+ saldo);
        }
    }
}
