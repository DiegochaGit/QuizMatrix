using Matrix.Logic;

try
{
    Console.WriteLine("Hello, Matrix!");
    int option;
    MyMatrix myMatrix = new(10);
    myMatrix.Fill();
    do
    {
        option = Menu();
        switch (option)
        {
            case 1:
                Console.Write("\nType the size of the square matrix: ");
                int n = Convert.ToInt32(Console.ReadLine());
                myMatrix = new MyMatrix(n);
                myMatrix.Fill();
                break;
            case 2:
                Console.WriteLine("\nMatrix:");
                Console.WriteLine(myMatrix);
                break;
            case 3:
                Console.WriteLine("\nMatrix:");
                Console.WriteLine(myMatrix);
                MyArray mainDiagonal = myMatrix.GetMainDiagonal();
                Console.WriteLine("*** Main Diagonal ***");
                Console.WriteLine(myMatrix.PrintMainDiagonal(mainDiagonal));
                break;
            case 4:
                Console.WriteLine("\nMatrix:");
                Console.WriteLine(myMatrix);
                var secondaryDiagonal = myMatrix.GetSecondaryDiagonal();
                Console.WriteLine("*** Secondary Diagonal ***");
                Console.WriteLine(myMatrix.PrintSecundaryDiagonal(secondaryDiagonal));
                break;
            case 0:
                Console.WriteLine("\nThe program has been over!!!!");
                option = 0;
                break;
            default:
                Console.WriteLine("\nFuck you. The option doesn't exist!!!!");
                break;
        }
    } while (option != 0);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

int Menu()
{
    Console.WriteLine("\n_____________________________________________");
    Console.WriteLine("OPTION MENU");
    Console.WriteLine("1. Define matrix size");
    Console.WriteLine("2. Show matrix");
    Console.WriteLine("3. Show principal diag");
    Console.WriteLine("4. Show secundary diag");
    Console.WriteLine("0. Exit");
    bool isValid = false;
    int option = 0;

    do
    {
        Console.WriteLine("____________________");
        Console.Write("Type your option: ");
        var optionString = Console.ReadLine();
        if (!int.TryParse(optionString, out option))
        {
            Console.WriteLine("\nInvalid option!!!  (only use numbers from 0 to 4).");
            isValid = false;
        }
        else
        {
            isValid = true;
        }
    } while (!isValid);
    return option;
}

