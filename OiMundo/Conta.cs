using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Conta
    {
        public double saldo;
        public string titular;
        public int numero;
        public int idade;


        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        
        public bool Saca(double valor)
        {
            if ((this.saldo<=valor) || this.idade < 18)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Transfere(Conta conta, double valor)
        {
            this.Saca(valor);
            conta.Deposita(valor);
        }
    }
}
