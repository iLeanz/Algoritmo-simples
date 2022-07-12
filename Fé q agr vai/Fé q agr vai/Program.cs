using System;

namespace Fé_q_agr_vai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Pra Garota q eu mais amo nesse mundo");
            double cod, amo, bah, op;
            cod = 1;

            while (cod == 1)
            {
                Console.Write("\n Posso te fazer umas perguntinhas? \n \n 1 - Sim \n 2 - Não: ");
                cod = Double.Parse(Console.ReadLine());
                switch (cod)
                {
                    case 1:
                        cod = 1; Console.WriteLine("\n Tem certeza disso? \n 1 - Sim \n 2 - Não:");
                        amo = Double.Parse(Console.ReadLine());
                        switch (amo)
                        {
                            case 1:
                               bah = 1; Console.WriteLine("\n Você acha que eu te amo? (parece meio grosso, mas não consgio pensar em nd melhor pq ja ta tarde) \n 1 - Sim \n 2 - Não:");
                               bah = Double.Parse(Console.ReadLine());

                                switch (bah)
                                {
                                    case 1:
                                        bah = 1; Console.Write("\n Amo mesmo, vc não faz ideia do quanto eu te amo (literalmente to a umas 3 horas fznd isso, e provavelmente vou dxr pra terminar amanhã), eu te amo pra krlh entendeu?  Vai ser apenas eu vc pra sempre minha loirinha");
                                        op = Double.Parse(Console.ReadLine());
                                        break;
                                    case 2:
                                        bah = 2; Console.Write("\n Ei, eu te amo sim entendeu? Sempre q vc tiver duvidas disso lembresse que são 3 da manha e eu to fznd isso aq pra vc skdskdsk, se lembra tbm de todas os textinhos boiola que eu fiz pra vc, das nossas calls e de todas as lembranças boas. Caso isso não funcione vc me liga ok?");
                                        op = Double.Parse(Console.ReadLine());
                                        break;
                                }
                                 break;
                        }
                        break;
                    case 2:
                        amo = 2; Console.WriteLine("É pra escolher a outra opção '-'");
                        amo = Double.Parse(Console.ReadLine());

                       
                        break;
                    default:
                        Console.WriteLine("Código errado amor, escolhe um certo pf");
                        break;
                }
                Console.WriteLine("É pra ter certeza amor -_-");
                break;

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
