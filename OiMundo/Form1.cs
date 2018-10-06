using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OiMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double saldo = 100;
            double valorDoSaque = 10;
            saldo -= valorDoSaque;
            MessageBox.Show("Saldo atual: " + saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadePaulo = 15;
            float media = (idadeJoao + idadeMaria + idadePaulo) / 3;
            MessageBox.Show("A Média: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pi = (int)3.14;
            MessageBox.Show(pi.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double delta, a1, a2;
            int a = 1, b = -2, c = 1;

            delta = b * b - 4 * a * c;
            if (delta<0)
            {
                MessageBox.Show("Delta não pode ser menor que 0");
            }
            else
            {
                a1 = (-b + Math.Sqrt(delta) / (2 * a));
                a2 = (-b - Math.Sqrt(delta) / (2 * a));
                MessageBox.Show("A1: " + a1 + " - A2: " + a2);
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100;
            double valorSaque = 10;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saldo atual: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }


        }
    }
}
