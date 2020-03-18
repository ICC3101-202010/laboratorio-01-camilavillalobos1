using System;

namespace Laboratorio_1_cv_poo
{
    class Persona
    {
        private string name;
        private string lastname;
        public Persona()

        {
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Lastname: ");
            lastname = Console.ReadLine();
        }

        public void Lanzar()

        {
            int randomNumber = new Random().Next(0, 3);
            Console.WriteLine(randomNumber);

        }
        static void Main(string[] args)
        {
            Persona person = new Persona();
            person.Lanzar();
            Console.ReadKey();
        }

    }
}