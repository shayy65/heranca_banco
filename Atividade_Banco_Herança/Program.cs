using Atividade_Banco_Herança.Classes;
using System.Security.AccessControl;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Conta conta = new Conta(01, "784", "João Pedro", 500);
            Estudantil estudantil = new Estudantil(500, "043.917.162-83", "IFRO Ji-Paraná", 02, "046", "Shaylla", 1000);
            Empresarial empresarial = new Empresarial(50, 5000, 0, 03, "047", "Vitor", 6000);

            while (true) 
            {
                Console.WriteLine("Qual o tipo de conta? \n" +
                    "0-Sair do programa. \n" +
                    "1-Normal. \n" +
                    "2-Estudantil. \n" +
                    "3-Empresarial.");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 0)
                {
                    goto exit;
                }
                else if (opcao == 1)
                {
                    
                    Console.WriteLine("Qual operação deseja fazer? \n" +
                        "1-Saque. \n" +
                        "2-Deposito");
                    int operacao = Convert.ToInt32(Console.ReadLine());

                    if (operacao == 1)
                    {
                        Console.WriteLine("Digite o valor do saque:");
                        double valorsaque = Convert.ToDouble(Console.ReadLine());
                        conta.Sacar(valorsaque);
                    }

                    else if (operacao == 2)
                    {
                        Console.WriteLine("Digite o valor do depósito:");
                        double valordeposito = Convert.ToDouble(Console.ReadLine());
                        conta.Depositar(valordeposito);
                    }

                    else
                    {
                        Console.WriteLine("Opção Inválida.");
                    }

                }
                else if (opcao == 2)
                {
                    
                    Console.WriteLine("Qual operação deseja fazer? \n" +
                        "1-Saque. \n" +
                        "2-Deposito");
                    int operacao = Convert.ToInt32(Console.ReadLine());

                    if (operacao == 1)
                    {
                        Console.WriteLine("Digite o valor do saque:");
                        double valorsaque = Convert.ToDouble(Console.ReadLine());
                        estudantil.Sacar(valorsaque);
                    }

                    else if (operacao == 2)
                    {
                        Console.WriteLine("Digite o valor do depósito:");
                        double valordeposito = Convert.ToDouble(Console.ReadLine());
                        estudantil.Depositar(valordeposito);
                    }

                    else
                    {
                        Console.WriteLine("Opção Inválida.");
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Qual operação deseja fazer? \n" +
                        "1-Saque. \n" +
                        "2-Deposito \n" +
                        "3-Empréstimo.");
                    int operacao = Convert.ToInt32(Console.ReadLine());

                    if (operacao == 1)
                    {
                        Console.WriteLine("Digite o valor do saque:");
                        double valorsaque = Convert.ToDouble(Console.ReadLine());
                        empresarial.Sacar(valorsaque);
                    }

                    else if (operacao == 2)
                    {
                        Console.WriteLine("Digite o valor do depósito:");
                        double valordeposito = Convert.ToDouble(Console.ReadLine());
                        empresarial.Depositar(valordeposito);
                    }

                    else if (operacao == 3)
                    {
                        Console.WriteLine("Digite o valor do emprestimo:");
                        double valoremprestimo = Convert.ToDouble(Console.ReadLine());
                        empresarial.FazerEmprestimo(valoremprestimo);
                    }

                    else
                    {
                        Console.WriteLine("Opção Inválida!");
                    }

                }

                else
                {
                    Console.WriteLine("Opção Inválida!");
                }
            }exit:;
            
        }catch(Exception ex)
        {
            Console.WriteLine("Erro Inexperado!" + ex.Message);
        }
        

    }
}
