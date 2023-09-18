using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Banco_Herança.Classes
{
    internal class Conta
    {
        public int Numeroconta { get; set; }
        public string Agencia { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta (int numeroconta,string agencia, string titular, double saldo )
        {
            Numeroconta = numeroconta;
            Agencia = agencia;
            Titular = titular;
            Saldo = saldo;

        }

        public void Sacar(double valorsaque)
        {
            try
            {
                double saque = Saldo - valorsaque;

                if (saque >= 0)
                {
                    Saldo -= valorsaque;
                    Console.WriteLine("Saldo realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }catch (Exception e) { Console.WriteLine("Erro Inexperado!" + e.Message); }
            

        }

        public void Depositar(double valordeposito)
        {
            try
            {
                Saldo =+ valordeposito;

                Console.WriteLine("Saldo realizado com sucesso.");
            }catch(Exception e) { Console.WriteLine("Erro inesperado!" + e.Message); }

        }
    }
}
