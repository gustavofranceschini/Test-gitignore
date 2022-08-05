using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa tem como objetivo aprender o git-ignore");
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Git git = new Git(name, idade);

            Console.WriteLine();

            Console.WriteLine("information people:");
            Console.WriteLine("Name: "+git.Name);
            Console.WriteLine("Idade: "+git.Idade);
        }
    }
}
