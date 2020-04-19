using System;
using System.Collections.Generic;



namespace Lab4POO
{
    public class Almacenamiento : CentralC, IFull, IFullManual
    {
        private string name;
        private double size;
        int size1;
        public List<Objetos> objetos = new List<Objetos> { };

        public Almacenamiento(string Name, double Size)
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

            return "Apagado completado: " + name;
        }




        public void Full()
        {
            size1 = objetos.Count;
            if (size1 == 10)
            {
                Console.WriteLine("Alerta: Memoria llena");
            }
            else
            {
                Console.WriteLine("Memoria disponible: ");
                Console.WriteLine(1- objetos.Capacity);
            }

        }
        public void FullManual()
        {
            for (int i = 0; i < 10; i++)
            {
                objetos.RemoveAt(0);
            }
            Console.WriteLine("Limpieza finalizada");
        }






        public override string Info()
        {
            return "Máquina: " + name + " Memoria: " + size;
        }
    }
}
