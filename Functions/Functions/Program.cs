using System.Security.Cryptography.X509Certificates;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }

        internal void Run()
        {
            Console.WriteLine("Dit is nu de start van mijn programma");
            Vraag1();
            Vraag2();
            Vraag3();
            Vraag4();
            Vraag5();
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
    }

}
