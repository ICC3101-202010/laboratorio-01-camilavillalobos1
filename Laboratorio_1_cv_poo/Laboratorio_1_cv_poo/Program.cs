using System;

namespace Laboratorio_1_cv_poo
{
    class Persona
    {
        private string name;
        private string lastname;
        public Persona(string name, string lastname)

        {
            this.name = name;
            this.lastname = lastname;
        }

        public string GetName()

        {
            return name;

        }

        public string GetLastname()

        {
            return lastname;

        }
        public void Lanzar()

        {
            int randomNumber = new Random().Next(0, 3);
            Console.WriteLine(randomNumber);

        }
        static void Main(string[] args)
        {
            Persona person = new Persona("Camila", "Villalobos");
            Console.WriteLine(person.GetName());
            Console.WriteLine(person.GetLastname());
            person.Lanzar();
        }

    }
}