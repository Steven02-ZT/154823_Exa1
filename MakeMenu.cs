using System;
class MakeMenu{
    private string[] options = {};
    public MakeMenu(string[] ops){
        options = ops;
    }

    public void PrintMenu(){
        Console.WriteLine();
        Console.WriteLine("Elije una de las opciones:");
        var index = 0;
        foreach (var option in options)
        {
            Console.WriteLine((index++) + ") " + option);
        }
        Console.WriteLine("Cualquier otro para salir.");
    }
}