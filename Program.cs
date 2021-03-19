using System;

namespace Music_Loves
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string MensagemDeErro = ("Desculpe, essa música ainda não foi adicionada em nossa lista.");
            string Nome;

            Console.Write("Oi, para começarmos por favor me diga seu nome: ");
            Nome = Console.ReadLine();
            Console.Clear();


            char Escolha;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Prazer {Nome}! Aqui estão algumas músicas para você verificar a letra.");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("(a) Say Something");
                Console.WriteLine("(b) Wish you were here");
                Console.WriteLine();
                Console.Write("Escolha a letra da música desejada: "); 
                Escolha = Console.ReadKey().KeyChar;
                Console.Clear();

                string musica1 = ($"{Nome} você selecionou Say Something.\n");
                string Musica2 = ($"{Nome} você selecionou Wish you were here.\n");

                if (Escolha.ToString().ToUpper() == "A")
                {
                    Console.WriteLine($"{musica1}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("SAY SOMETHING (feat.Christina Aguilera)");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("A Great Big World \n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Say something, I'm giving up on you");
                    Console.WriteLine("I'll be the one, if you want me to");
                    Console.WriteLine("Anywhere, I would've followed you");
                    Console.WriteLine("Say something, I'm giving up on you \n");
                    Console.ResetColor();
                    Console.WriteLine("And I am feeling so small");
                    Console.WriteLine("It was over my head");
                    Console.WriteLine("I know nothing at all \n");
                    Console.WriteLine("And I will stumble and fall");
                    Console.WriteLine("I'm still learning to love");
                    Console.WriteLine("Just starting to crawl \n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Say something, I'm giving up on you");
                    Console.WriteLine("I'm sorry that I couldn't get to you");
                    Console.WriteLine("Anywhere, I would've followed you");
                    Console.WriteLine("Say something, I'm giving up on you \n");
                    Console.ResetColor();
                    Console.WriteLine("And I will swallow my pride");
                    Console.WriteLine("You're the one that I love");
                    Console.WriteLine("And I'm saying goodbye \n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Say something, I'm giving up on you");
                    Console.WriteLine("And I'm sorry that I couldn't get to you");
                    Console.WriteLine("And anywhere, I would have followed you");
                    Console.WriteLine("Ooh, ooh say something, I'm giving up on you \n");
                    Console.WriteLine("Say something, I'm giving up on you");
                    Console.Write("Say something \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();

                }

                else if (Escolha.ToString().ToUpper() == "B")
                {
                    Console.WriteLine($"{Musica2}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("WISH YOU WERE HERE");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Pink Floyd \n");
                    Console.ResetColor();
                    Console.WriteLine("So, so you think you can tell");
                    Console.WriteLine("Heaven from hell?");
                    Console.WriteLine("Blue skies from pain?");
                    Console.WriteLine("Can you tell a green field");
                    Console.WriteLine("From a cold steel rail?");
                    Console.WriteLine("A smile from a veil?");
                    Console.WriteLine("Do you think you can tell? \n");
                    Console.WriteLine("Did they get you to trade");
                    Console.WriteLine("Your heroes for ghosts?");
                    Console.WriteLine("Hot ashes for trees?");
                    Console.WriteLine("Hot air for a cool breeze?");
                    Console.WriteLine("Cold comfort for change?");
                    Console.WriteLine("Did you exchange");
                    Console.WriteLine("A walk on part in the war");
                    Console.WriteLine("For a lead role in a cage? \n");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("How I wish");
                    Console.WriteLine("How I wish you were here");
                    Console.WriteLine("We're just two lost souls");
                    Console.WriteLine("Swimming in a fish bowl");
                    Console.WriteLine("Year after year");
                    Console.WriteLine("Running over the same old ground");
                    Console.WriteLine("What have we found?");
                    Console.WriteLine("The same old fears");
                    Console.Write("Wish you were here \n");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                }
                else{
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{MensagemDeErro}");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                do
                {
                    Console.Clear();
                    Console.Write($"\n{Nome} você quer voltar e ver a letra de outras musicas?[s/n] ");
                    //Escolha = Char.Parse(Console.ReadLine());
                    Escolha = Console.ReadKey().KeyChar;
                    Console.Clear();

                    if (Escolha.ToString().ToUpper() == "S")
                    {
                        break;
                    }
                    else if (Escolha == 'n' || Escolha == 'N')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"{Nome} muito obrigada por interagir com o programa.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Desculpe essa opção não é valida, você será redirecionado.");
                        Console.ResetColor();
                        Console.ReadKey();
                    }
                }while (Escolha.ToString().ToUpper() != "N");

            } while (Escolha.ToString().ToUpper() != "N");
    }
}
