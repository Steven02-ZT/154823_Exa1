namespace Examen1{
    class Ejercicio2
{

    private Start start;
    public Ejercicio2(Start program){
        this.start = program;
    }

    struct Book
    {
        public int Code;
        public string Title;
        public string ISBN;
        public int Edition;
        public string Author;
    }

    private Book[] library = new Book[100]; 
    private int bookCount = 0; 

    private string[] options = new string[] {"Agregar libro","Mostrar libros","Buscar libro","Editar libro"};
    public void StartProcess()
    {
        while (true)
        {
            MakeMenu menu = new MakeMenu(options);
            menu.PrintMenu();
            string option = Console.ReadLine();

            switch (option)
            {
                case "0":
                    AddBook();
                    break;

                case "1":
                    ShowBooks();
                    break;

                case "2":
                    SearchBook();
                    break;

                case "3":
                    EditBook();
                    break;

                default: start.Run(); break;
            }
        }
    }

    private void AddBook()
    {
        if (bookCount < library.Length)
        {
            Book newBook = new Book();

            Console.Write("Ingresa el codigo del libro (numeros enteros): ");
            newBook.Code = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el titulo del libro: ");
            newBook.Title = Console.ReadLine();

            Console.Write("Ingresa el ISBN: ");
            newBook.ISBN = Console.ReadLine();

            Console.Write("Ingresa el numero de edicion del libro (numeros enteros): ");
            newBook.Edition = int.Parse(Console.ReadLine());

            Console.Write("Ingresa el autor del libro: ");
            newBook.Author = Console.ReadLine();

            library[bookCount] = newBook;
            bookCount++;

            Console.WriteLine("Libro agregado correctamente!.");
        }
        else
        {
            Console.WriteLine("Libreria llena, no puedes agregar mas libros.");
        }
    }

    private void ShowBooks()
    {
        if (bookCount == 0)
        {
            Console.WriteLine("Libreria vacia ups!.");
        }
        else
        {
            Console.WriteLine("Lista de libros:");
            Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10} {4,-20}", "Codigo", "Titulo", "ISBN", "Edicion", "Autor");
            Console.WriteLine(new string('-', 75));

            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine("{0,-10} {1,-30} {2,-15} {3,-10} {4,-20}",
                    library[i].Code, library[i].Title, library[i].ISBN, library[i].Edition, library[i].Author);
            }
        }
    }

    private void SearchBook()
    {
        Console.Write("Ingresa el codigo del libro a buscar: ");
        int codeToSearch = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            if (library[i].Code == codeToSearch)
            {
                Console.WriteLine("Libro encontrado:");
                Console.WriteLine("Codigo: {0}", library[i].Code);
                Console.WriteLine("Tirulo: {0}", library[i].Title);
                Console.WriteLine("ISB: {0}", library[i].ISBN);
                Console.WriteLine("Edicion: {0}", library[i].Edition);
                Console.WriteLine("Autor: {0}", library[i].Author);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    private void EditBook()
    {
        Console.Write("Ingresa el codigo del libro a editar: ");
        int codeToEdit = int.Parse(Console.ReadLine());

        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            if (library[i].Code == codeToEdit)
            {
                Console.WriteLine("Ingresa la nueva informacion:");

                Console.Write("Nuevo codigo: ");
                library[i].Code = int.Parse(Console.ReadLine());

                Console.Write("Nuevo titulo: ");
                library[i].Title = Console.ReadLine();

                Console.Write("Nuevo ISBN: ");
                library[i].ISBN = Console.ReadLine();

                Console.Write("Nuevo numero de edicion: ");
                library[i].Edition = int.Parse(Console.ReadLine());

                Console.Write("Nuevo editor: ");
                library[i].Author = Console.ReadLine();

                Console.WriteLine("Libro editado satisfactoriamente.");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }
}

}