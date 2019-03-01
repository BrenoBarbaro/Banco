using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mercado
{
    class Conta
    {
        double saldo = 0;

        public double Saque(double valor)
        {
            return saldo -= valor;
        }

        public double Deposito(double deposito)
        {
            return saldo += deposito;
        }

        public double MostraSaldo()
        {
            return saldo;
        }
    }
}
