using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo_banco_1
{
    public partial class Form1 : Form
    {
        Conta[] novaConta = new Conta[5];
        int x = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++) 
            {
                novaConta[i] = new Conta();
            }
        }

        public void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novaConta[x].NomeCliente = textBox1.Text;
            novaConta[x].Numero = int.Parse(textBox2.Text);
            novaConta[x].Tipo = comboBox1.SelectedIndex;
            novaConta[x].Saldo = float.Parse(textBox4.Text);
            MessageBox.Show("Cadastrado com sucesso!");
            Limpar();
            x++;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                x = 0;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                x = 1;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                x = 2;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                x = 3;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                x = 4;
            }
            else
            {
                MessageBox.Show("Selecione algum dos tipos!");
            }
            textBox1.Text = novaConta[x].NomeCliente;
            textBox2.Text = novaConta[x].Numero.ToString();
            textBox4.Text = novaConta[x].Saldo.ToString();
            if (novaConta[x].Tipo == 0)
            {
                comboBox1.SelectedItem = 0;
            }
            else
            {
                comboBox1.SelectedItem = 1;
            }
        }

        private void depositar_Click(object sender, EventArgs e)
        {
            novaConta[x].Saldo = novaConta[x].Saldo + float.Parse(textBox5.Text);
            MessageBox.Show("Depositado com Sucesso!");
            Limpar();
        }

        private void Sacar_Click(object sender, EventArgs e)
        {
            if (novaConta[x].Saldo >= float.Parse(textBox6.Text))
            {
                novaConta[x].Saldo = novaConta[x].Saldo - float.Parse(textBox6.Text);
                MessageBox.Show("Saque realizado com sucesso!");
            }
            else 
            {
                MessageBox.Show("Saque não realizado. Saldo insuficiente");
            }
            Limpar();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void mostrarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo atual é R$ " + novaConta[x].Saldo);
        }

        private void mostratInformaçõesContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (novaConta[x].Tipo == 0)
            {
                MessageBox.Show("Nome " + novaConta[x].NomeCliente +
                "\nConta " + novaConta[x].Numero +
                "\nTipo Conta-corrente");
            }
            else
            {
                MessageBox.Show("Nome " + novaConta[x].NomeCliente +
                                "\nConta " + novaConta[x].Numero +
                                "\nTipo Poupança");
            }

        }

        private void mostrarSaldoPoupançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poupanca p = new Poupanca();
            p.extratoPoupanca();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
