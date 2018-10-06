using System;
using System.Collections.Generic;
using System.Text;

namespace SaldoPoupanca
{
    class Poupanca
    {
        private static double taxadejuros;
        private decimal saldopoupanca;

        private int MESES = 12;
        
        public Poupanca() { }

        public Poupanca(decimal saldopoupanca)
        {
            this.saldopoupanca = saldopoupanca;
            taxadejuros = 0.0;
        }

        //Configurar saldo
        public decimal Saldo
        {
            get
            {
                return saldopoupanca;
            }
            set
            {
                saldopoupanca = value;
            }
        }
        //Pega ou configura a taxa de juros anual
        public static double TaxadeJuros
        {
            get
            {
                return taxadejuros;
            }
            set
            {
                taxadejuros = value;
            }
        }
        //Calcula o juros mensais da poupança acrescidos do saldo atual
        public decimal CalcularJurosMensal()
        {
            decimal jurosMensal = ((saldopoupanca * (decimal)taxadejuros) / MESES);
            decimal saldopoupador = jurosMensal + saldopoupanca;
            return saldopoupador;
        }
        //Altera a taxa de juros da conta poupança
        public static void AlterataxadeJuros(double Taxadejuros)
        {
            taxadejuros = Taxadejuros;
        }
    }
}
