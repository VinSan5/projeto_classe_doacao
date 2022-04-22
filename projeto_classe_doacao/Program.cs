using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_donation_tier
{
    internal class donation_tier
    {
        static void Main(string[] args)
        {/* Programa: Classe de doadores
          * Problema: Projeto de universidade. Utilização de condicionais. Programa em terminal que permite a escolha de instituição para doação, info sobre instituições. Separa o usuário
          *           em classes de acordo com o valor doado
          * Data....: 19/04/2022
          * Autor...: Vinícius Santos | 11221103398
          */


            // Declaração de variáveis
            double valor_doacao, conf_doac;
            int gettoknow, info, opt1, confirm;
            string nome;

            // Introdução
            Console.WriteLine("Doação à institutos!");
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("\nObrigado por demonstrar interesse em apoiar as instituições");
            System.Threading.Thread.Sleep(1500);

            Console.Write("\nPara que possamos começar, informe o seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("\nOlá, {0}! Que bom ter você por aqui! Use os números apresentados para navegar pelos menus", nome);
            System.Threading.Thread.Sleep(1500);

            Console.WriteLine("\nPressione\n1. Conhecer o projeto\n2. Ir para a seleção de instituto/ORG/ONG");
            gettoknow = int.Parse(Console.ReadLine());
            if (gettoknow == 1)
            {
                goto Intro1;
            }
            if (gettoknow == 2)
            {
                goto Start;
            }

        // Explicação ao usuário
        Intro1:
            Console.WriteLine("\nEste projeto tem como função despertar interesse nas pessoas em ajudar organizações e institutos de apoio\nQuanto mais você doar, mais você ganha!");
            System.Threading.Thread.Sleep(1500);
        Intro2:
            Console.WriteLine("\n|  R$0,01 - R$24.99: Doador Bronze    |\n|  R$25 - R$49.99: Doador Prata       |\n|  R$50 - R$99.99: Doador Ouro        |\n|  R$100 - R$499.99: Doador Platina   |\n|  R$500 - R$999.99: Doador Diamante  |\n|  R$1000 em diante: Doador VIP       |");
            Console.WriteLine("\nPara mais informações dos benefícios, digite:\n1. Info Bronze\n2. info Prata\n3. Info Ouro\n4. Info Platina\n5. Info Diamante\n6. Info VIP");
            info = int.Parse(Console.ReadLine());
            if (info == 1)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nBenefícios Classe Bronze\n* * * incluir benefícios * * *");
            }
            if (info == 2)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nBenefícios Classe Prata\n* * * incluir benefícios * * *");
            }
            if (info == 3)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nBenefícios Classe Ouro\n* * * incluir benefícios * * *");
            }
            if (info == 4)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nBenefícios Classe Platina\n* * * incluir benefícios * * *");
            }
            if (info == 5)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nBenefícios Classe Diamante\n* * * incluir benefícios * * *");
            }
            if (info == 6)
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\nBenefícios Classe VIP\n* * * incluir benefícios * * *");
            }

            Console.WriteLine("\nOs benefícios de grupo são atualizados mensalmente\n\nDeseja prosseguir para a doação? Digite\n1. para prosseguir para a doação\n2. Informação de grupos\n3. Sair do programa");
            gettoknow = int.Parse(Console.ReadLine());
            if (gettoknow == 1)
            {
                goto Start;
            }
            if ((gettoknow == 2))
            {
                goto Intro2;
            }
            if (gettoknow == 3)
            {
                goto End;
            }

            // Seleção de instituto
            Console.WriteLine("\nIrei te mostrar agora as instituições parceiras");

        Start: // Label para que o usuário retorne caso queira mudar sua escolha
            Console.WriteLine("\nSelecione uma das opções abaixo");
            Console.WriteLine("\n1. *ORG 1*\n2. *ORG 2*\n3. *ORG 3*");
            opt1 = int.Parse(Console.ReadLine());


            if (opt1 == 1)
            {
                Console.WriteLine("\n*ORG 1* selecionada. Pressione 1 para confirmar a sua seleção, ou 0 para voltar ao menu anterior");
                confirm = int.Parse(Console.ReadLine());
                if (confirm == 0)
                {
                    goto Start;
                }
                if (confirm == 1)
                {
                    Console.WriteLine("\nObrigado por optar pela *ORG 1*!");
                }
                if (confirm == 1)
                {
                    goto Valores;
                }
            }

            else if (opt1 == 2)
            {
                Console.WriteLine("*ORG 2* selecionada. Pressione 1 para confirmar a sua seleção, ou 0 para voltar ao menu anterior");
                confirm = int.Parse(Console.ReadLine());
                if (confirm == 0)
                {
                    goto Start;
                }
                if (confirm == 1)
                {
                    Console.WriteLine("\nObrigado por optar pela *ORG 2*!");
                }
                else if (confirm == 1)
                {
                    goto Valores;
                }

            }

            else if (opt1 == 3)
            {
                Console.WriteLine("*ORG 3* selecionada. Pressione 1 para confirmar a sua seleção, ou 0 para voltar ao menu anterior");
                confirm = int.Parse(Console.ReadLine());
                if (confirm == 0)
                {
                    goto Start;
                }
                if (confirm == 1)
                {
                    Console.WriteLine("\nObrigado por optar pela *ORG 3*!");
                }
                else if (confirm == 1)
                {
                    goto Valores;
                }
            }



        Valores: // Designação da classe do doador

            Console.WriteLine("\nOk.\n\nInforme agora o valor que quer doar\nObs.: use ',' para os centavos");
            valor_doacao = double.Parse(Console.ReadLine());
            Console.WriteLine("\n{0}, você confirma a sua doação no valor de {1}?\n1. confirma\n2. corrigir", nome, valor_doacao);
            conf_doac = double.Parse(Console.ReadLine());

            // designação de grupo
            if (valor_doacao < 25)
                {
                Console.WriteLine("Obrigado! Agora você é um doador classe Bronze!");
                }
            else
                if (valor_doacao < 50)
                    {
                Console.WriteLine("Obrigado! Agora você é um doador classe Prata!");
                    }
            else
                    if (valor_doacao < 100)
                        {
                Console.WriteLine("Obrigado! Agora você é um doador classe Ouro!");
                        }
            else
                        if (valor_doacao < 500)
                            {
                Console.WriteLine("Obrigado! Agora você é um doador classe Platina!");
                            }
            else
                            if (valor_doacao < 999.99)
                            {
                Console.WriteLine("Obrigado! Agora você é um doador classe Diamante!");
                                }
            else
                                if (valor_doacao >= 1000)
                                {
                Console.WriteLine("\nObrigado! Agora você é um doador classe Diamante!");
                                }

            if (conf_doac == 1)
            {
                goto Perks;
            }
            if (conf_doac == 2)
            {
                goto Valores;
            }

        Perks:
            Console.WriteLine("\nVocê pode resgatar seus benefícios pelo site *link site*, ou no nosso app *link app*");

        // Final
        End:
            Console.WriteLine("\nPressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
