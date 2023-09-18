using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Banco_Herança.Classes
{
    internal class Estudantil : Conta
    {
        public double Limitecheque { get; set; }
        public string Cpf { get; set; }
        public string Nomeinstituicao { get; set; }

        public Estudantil(double limitecheque, string cpf, string nomeinstituicao, int numeroconta, string agencia, string titular, double saldo) 
            : base (numeroconta, agencia,titular,saldo)
        {
            Limitecheque = limitecheque;
            Cpf = cpf;
            Nomeinstituicao = nomeinstituicao;
        }

        public void Sacar (double valorsaque)
        {
            try
            {
                double saque = (Saldo + Limitecheque) - valorsaque;

                if (saque >= 0)
                {
                    Saldo -= valorsaque;
                    Console.WriteLine("Saldo realizado com sucesso!");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            catch (Exception e) { Console.WriteLine("Erro Inexperado!" + e.Message); }

        }
    }
}
