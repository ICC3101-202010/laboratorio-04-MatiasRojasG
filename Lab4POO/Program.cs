using System;
using System.Collections.Generic;


namespace Lab4POO
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string respuesta1; //Elija una opcion
            string respuesta2; //Elegir maquina -> Que maquina desea ver?



            Recepcion recepcion = new Recepcion("Recepcion",10);
            Almacenamiento almacenamiento = new Almacenamiento("Almacenamiento", 10);
            Ensamblaje ensamblaje = new Ensamblaje("Ensamblaje", 10);
            Verificacion verificacion = new Verificacion("Verificacion", 10);
            Empaque empaque = new Empaque("Empaque", 10);



            //Se encienden las maquinas
            Console.WriteLine("Inicializando...");
            Console.WriteLine(recepcion.Encendido());
            Console.WriteLine(almacenamiento.Encendido());
            Console.WriteLine(ensamblaje.Encendido());
            //Console.WriteLine(verificacion.Endendido());
            //Console.WriteLine(empaque.Encendido());

            while (true)
            {

                Console.WriteLine("Menú:");
                Console.WriteLine("Elija una opcion numérica:");
                Console.WriteLine("1) Ingresar objetos (Comenzar Programa)");
                Console.WriteLine("2) Reiniciar máquina");
                Console.WriteLine("3) Apagar máquinas");
                respuesta1 = Console.ReadLine();

                Console.WriteLine(" ");

                if (respuesta1 == "1")
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Objetos a = new Objetos("Objeto " + i);
                        recepcion.objetos.Add(a);
                        almacenamiento.objetos.Add(a);
                        ensamblaje.objetos.Add(a);
                        verificacion.objetos.Add(a);
                        empaque.objetos.Add(a);
                    }
                    Console.WriteLine(" ");
                }




                if (respuesta1=="2")
                {
                    Console.WriteLine("¿Que maquina desea reiniciar?");
                    respuesta2 = Console.ReadLine();
                    if (respuesta2=="Recepcion")
                    {
                        recepcion.Reinicio();
                        recepcion.FullManual();
                    }
                    Console.WriteLine(" ");
                    if (respuesta2=="Almacenamiento")
                    {
                        almacenamiento.Reinicio();
                        almacenamiento.FullManual();
                    }
                    if (respuesta2=="Ensamblaje")
                    {
                        ensamblaje.Reinicio();
                        ensamblaje.FullManual();
                    }
                    if (respuesta2=="Verificacion")
                    {
                        verificacion.Reinicio();
                        verificacion.FullManual();
                    }
                    if (respuesta2=="Empaque")
                    {
                        empaque.Reinicio();
                        empaque.FullManual();
                    }

                }




                if (respuesta1=="3")
                {
                    Console.WriteLine(recepcion.Apagado());
                    Console.WriteLine(almacenamiento.Apagado());
                    Console.WriteLine(ensamblaje.Apagado());
                    Console.WriteLine(verificacion.Apagado());
                    Console.WriteLine(empaque.Apagado());
                    break;
                }



                //Avisa si hay alguna maquina con memoria llena
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                if (recepcion.objetos.Count == 10)
                {
                    Console.WriteLine("Recepcion:");
                    Console.WriteLine("Favor reiniciar Recepcion");
                }
                Console.WriteLine(" ");
                if (almacenamiento.objetos.Count == 10)
                {
                    Console.WriteLine("Almacenamiento:");
                    Console.WriteLine("Memoria llena! Favor reiniciar Almacenamiento");
                }
                Console.WriteLine(" ");
                if (ensamblaje.objetos.Count == 10)
                {
                    Console.WriteLine("Ensamblaje:");
                    Console.WriteLine("Favor reiniciar Ensamblaje");
                }
                Console.WriteLine(" ");
                if (verificacion.objetos.Count == 10)
                {
                    Console.WriteLine("Verificacion:");
                    Console.WriteLine("Memoria llena! Favor reiniciar Verificacion");
                }
                Console.WriteLine(" ");
                if (empaque.objetos.Count == 10)
                {
                    Console.WriteLine("Empaque:");
                    Console.WriteLine("Memoria llena! Favor reiniciar Empaque");
                }

            }


        }
    }
}
