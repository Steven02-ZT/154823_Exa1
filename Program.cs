using System.Xml;

namespace Examen1{
    class Program{
        static void Main(){
            Start start = new Start();
            start.Run();
        }
    }

    class Start{
        public void Run(){
            string[] values = new string[] {"Ejercicio 1","Ejercicio 2"};
            MakeMenu menu = new MakeMenu(values);

            Ejercicio1 ejercicio1 = new Ejercicio1();
            Ejercicio2 ejercicio2 = new Ejercicio2(this);

            var exit = false;
            while (!exit)
            {
                menu.PrintMenu();
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 0: ejercicio1.Calculate(); break;
                    case 1: ejercicio2.StartProcess(); break;
                    default: Environment.Exit(0); break;
                }
            }
        }
    }
}