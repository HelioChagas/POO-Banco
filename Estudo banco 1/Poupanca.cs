using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Estudo_banco_1
{
    class Poupanca
    {
        private double saldopoupanca = 0.0;
        public double SaldoPoupanca { get => saldopoupanca; set => saldopoupanca = value ; }
        public void extratoPoupanca() 
        {
            MessageBox.Show("Meu saldo poupança é R$"+ saldopoupanca);
        }
    }
}
