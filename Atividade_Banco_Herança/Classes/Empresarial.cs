using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Banco_Herança.Classes
{
    internal class Empresarial : Conta
    {
        public double Anuidade { get; set; }
        public double Limiteemprestimo { get; set; }
        public double Totalemprestimo { get; set; }

        public Empresarial(double anuidade, double limiteemprestimo, double totalemprestimo, int numeroconta, string agencia, string titular, double saldo) 
            : base (numeroconta, agencia, titular, saldo)
        {
            Anuidade = anuidade;
            Limiteemprestimo = limiteemprestimo;
            Totalemprestimo = totalemprestimo;
        }

        public void FazerEmprestimo(double valoremprestimo)
        {
            try
            {
                if(valoremprestimo <= Limiteemprestimo )
                {
                    Limiteemprestimo -= valoremprestimo;
                    Saldo += valoremprestimo;
                    Totalemprestimo += valoremprestimo;

                    Console.WriteLine("Empréstimo realizado com sucesso!");

                }
                else
                {
                    Console.WriteLine("Empréstimo negado!");
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("Erro inesperado" + e.Message);
            }


        }
        //gg
        public override void Sacar(double valorsaque)
        {
            try
            {
                double saque = Saldo - valorsaque;

                if (saque >= 0)
                {
                    if(valorsaque > 5000)
                    {
                        double saque2 = Saldo - (valorsaque + 5) ;

                        if(saque2 >= 0 )
                        {
                            Console.WriteLine("Saque realizado com sucesso!");
                        }

                        else if(saque2 < 0)
                        {
                            Console.WriteLine("Saldo Insuficiente.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saque realizado com sucesso!");
                    }
                }

                else if(saque < 0)
                {
                    Console.WriteLine("Saldo insuficiente.");
                }

                
            }
            catch (Exception e) { Console.WriteLine("Erro Inexperado!" + e.Message); }
        }
    }
}
