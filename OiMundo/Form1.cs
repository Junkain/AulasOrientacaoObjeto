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
            if (delta < 0)
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
            double saldo = 5;
            double valorSaque = 10;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saldo atual: " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente " + saldo);
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 100;
            double taxa;
            if (saldo < 1000)
            {
                taxa = 0.01;
            }
            else if (saldo <= 5000)
            {
                taxa = 0.05;
            }
            else
            {
                taxa = 0.1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 1000;
            if (saldo < 0.0)
            {
                MessageBox.Show("Está negativado");
            }
            else if (saldo < 1000000)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é um milionário");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool brasileira = true;
            int idade = 17;

            if (idade < 18)
            {
                MessageBox.Show("Não pode votar ");
            }
            else if (!brasileira)
            {
                MessageBox.Show("Não pode votar");
            }
            else
            {
                MessageBox.Show("Pode votar");
            }
        }
            
        private void button9_Click(object sender, EventArgs e)
        {
            double valorNotaFiscal = 3000;
            if (valorNotaFiscal > 7000)
            {
                MessageBox.Show("Imposto 3%");
            }
            else if (valorNotaFiscal > 2999)
            {
                MessageBox.Show("Imposto 2.8%");
            }
            else if (valorNotaFiscal > 999)
            {
                MessageBox.Show("Imposto 2.5%");
            }
            else
            {
                MessageBox.Show("Imposto 2%");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int valor = 15;
            string mensagem = "";
            mensagem = valor > 10 ? "Valor maior que 10" : "Valor menos que 10";
            MessageBox.Show(mensagem);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int total = 2;
            for (int i = 0; i < 5; i++)
            {
                total *= 2;
            }
            MessageBox.Show("Total no final: " + total);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show("Linha: " + (i+1));
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show("Número: "+i);
                }
                else
                {
                    MessageBox.Show("Não é divisivel" + i);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (!(i % 3 ==0))
                {
                    total += i;
                }
            }
            MessageBox.Show("Total: " + total);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < 10; i++)
            {
                if (!(i%3==0 || i%4==0))
                {
                    total += i;
                }
                
            }
            MessageBox.Show("Total: " + total);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int n = 0; n <= 5; n++)
            {
                int fatorial = 1;
                for (int i = 1; i <= n; i++)
                {
                    fatorial *= i;
                }
                MessageBox.Show("Fatorial de: " + n + " é: " + fatorial);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int num = 0;
            int temp = 0;
            for (int i = 0; i < 21; i++)
            {
                num = temp + i;

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Conta continha = new Conta();
            continha.titular = "Ellem";
            continha.saldo = 2000;
            continha.numero = 1234;

            MessageBox.Show(continha.titular + " Dono da conta");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.titular = "Ellem";
            c.saldo = 1000;
            c.idade = 16;

            MessageBox.Show("Valor atual: " + c.saldo);
            c.Deposita(100);
            MessageBox.Show("Valor atual: " + c.saldo);
            if (c.Saca(200))
            {
                MessageBox.Show("Sucesso");
            }
            else
            {
                MessageBox.Show("Insuficiente");
            }
            MessageBox.Show("Valor atual: " + c.saldo);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            Conta c2 = new Conta();

            c1.numero = 1;
            c1.saldo = 10;
            c1.titular = "haha";

            c2.numero = 1;
            c2.saldo = 10;
            c2.titular = "haha";

            if (c1 == c2)
            {
                MessageBox.Show("São iguais");
            }
            else
            {
                MessageBox.Show("Não são tão");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.saldo = 1000;
            Conta c2 = new Conta();
            c2.saldo = 1000;

            c.Transfere(c2, 200);
            MessageBox.Show("Conta 1: " + c.saldo + " Conta 2: "+ c2.saldo);
        }
    }
}
