using System;
using System.Collections.Generic;
using System.Text;

namespace Exercico2_2
{
    public class Cliente
    {
        private int Saldo;
        private int Conta;
        private int Cobranças;
        private int Credito;
        private int LimiteDeCredito;

        public Cliente(int Saldo, int Conta, int Cobrança, int Credito, int LimiteDeCredito)
        {
            this.Saldo = Saldo;
            this.Conta = Conta;
            this.Cobranças = Cobrança;
            this.Credito = Credito;
            this.LimiteDeCredito = LimiteDeCredito;
        }

        public int CalcularNovoSaldo()
        {
            return this.Saldo + this.Cobranças - this.Credito;
        }

        public void AtualizarSaldo()
        {
            this.Saldo = CalcularNovoSaldo();
        }

        public bool ultrapassarLimite()
        {
            return this.Saldo > LimiteDeCredito;
        }


    }
}
