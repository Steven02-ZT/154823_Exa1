namespace Examen1{
    class Ejercicio1{
    private string[] keys = new string[] {"12","15","18","19","23"};
    private  double minutesCost = 0;
    private int key = 0;
    private double minutes = 0;

    public void GiveDates(){
        Console.WriteLine("Ingrese la clave de la zona");
        MakeMenu menu = new MakeMenu(keys);
        menu.PrintMenu();
        this.key = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el número de minutos utilizados:");
        this.minutes = double.Parse(Console.ReadLine());
    }

    public void CalculateCost(){
        switch (key)
        {
            case 0:
                minutesCost = 2;
                break;

            case 1:
                minutesCost = 2.2;
                break;

            case 2:
                minutesCost = 4.5;
                break;

            case 3:
                minutesCost = 3.5;
                break;

            case 4:
                minutesCost = 6;
                break;

            default:
                Console.WriteLine("Clave de zona no válida.");
                return;
        }

        double TotalCost = minutesCost * minutes;

        Console.WriteLine($"El costo de la llamada es: ${TotalCost}");
    }

    public void Calculate(){
        this.GiveDates();
        this.CalculateCost();
    }
}
}