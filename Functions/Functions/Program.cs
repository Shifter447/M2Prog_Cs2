using System.Security.Cryptography.X509Certificates;

namespace Functions
{
    internal class Program
    {
        string[] vragen = new string[] {
            "What 1997 N64 video game, features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan?"
        };

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }

        internal string GetVraag(int vraagIndex)
        {
            return vragen[vraagIndex];
        }
        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
            string antwoord6 = Vraag6();
            Console.WriteLine(antwoord6);
            string vraag0 = GetVraag(0);
            Console.WriteLine(vraag0);
        }
            
        internal void Vraag1()
        {
            Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        
        }
        internal void Vraag2()
        {
            Console.WriteLine("Do you like pizza?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag3()
        {
            Console.WriteLine("What is your favorite game?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag4()
        {
            Console.WriteLine("How old are you?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal void Vraag5()
        {
            Console.WriteLine("What is your most cherished memory?");
            string antwoord = Console.ReadLine();

            Console.WriteLine(antwoord);
        }
        internal string Vraag6()
        {
            Console.WriteLine("Wat wil je later doen?");
            string antwoord = Console.ReadLine();

            return antwoord;  
        }
        internal string GetRandomVraag()
        {
            int random = ;
            return random;

;
        }
    }

}
