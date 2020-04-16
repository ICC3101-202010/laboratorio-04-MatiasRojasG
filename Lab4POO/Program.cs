using System;
using System.Collections.Generic;


namespace Lab4POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Recepcion recepcion = new Recepcion("Recepcion",10);
            Console.WriteLine(recepcion.Info());


            //Se encienden las maquinas
            Console.WriteLine("Inicializando...");
            Console.WriteLine(recepcion.Encendido());
            //almacenamiento.Encendid();
            //ensamblaje.Encendido();
            //verificacion.Endendido();
            //empaque.Encendido();




            for (int i=1; i<=10;i++)
            {
                Objetos a = new Objetos("Objeto " + i);
                a.Info();
                recepcion.objetos.Add(a);
                //almacenamiento.objetos.Add(a)
                //ensamblaje.objetos.Add(a)
                //verificacion.objetos.Add(a)
                //empaque.objetos.Add(a);
            }
            recepcion.Full();
            //almacenamiento.Full():
            //ensamblaje.Full():
            //verificacion.Full():
            //empaque.Full():



        }
    }
}
