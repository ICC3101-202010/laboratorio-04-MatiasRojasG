using System;
using System.Collections.Generic;


namespace Lab4POO
{
    public class Recepcion : CentralC, IFull
    {
        private string name;
        private double size;
        int size1;
        public List<Objetos> objetos = new List<Objetos> {};

        public Recepcion(string Name,double Size)
        {
            this.name = Name;
            this.size = Size;
        }


        public override string Encendido()
        {
            return "Encendido completado de: " + name;
        }

        public override string Reinicio()
        {
            return "Reinicio y formateo completado";

        }

        public override string Apagado()
        {

            return "Apagado completado" + name;
        }



        public void Full()
        {
            size1 = objetos.Count;
            Console.WriteLine(size1);
            if (size1 == 10)
            {
                Console.WriteLine("Alerta: Memoria llena");
                Console.WriteLine(Reinicio());
                for (int i=0;i<size1;i++)
                {
                    objetos.RemoveAt(0);
                }
            }
            if (objetos.Count < 10)
            {
                Console.WriteLine("Memoria disponible");
                Console.WriteLine(10 - objetos.Count);
            }
        }






        public override string Info()
        {
            return "Máquina: " + name + " Memoria: " + size;
        }
    }
}
