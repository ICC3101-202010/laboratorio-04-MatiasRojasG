using System;
using System.Collections.Generic;


namespace Lab4POO
{
    public class Objetos
    {
        private string name;

        public Objetos(string Name)
        {
            this.name = Name;
        }
        public void Info()
        {
            Console.WriteLine("Nombre objeto: " + name);
        }
    }
}
