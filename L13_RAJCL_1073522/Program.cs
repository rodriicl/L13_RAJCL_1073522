class Program
{
    static void Main()
    {
        int[] años = new int[5];
        string[] nombre = new string[5];

        for (int f = 0; f < 5; f++) 
        {
            Console.WriteLine("Ingrese su nombre: ");
            nombre[f] = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            años[f] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Las personas que son mayores de edad son las siguientes: ");

        for (int f = 0; f < 5; f++)
        {
            if (años[f] >= 18)
            {
                Console.WriteLine(nombre[f] + " con " + años[f] + " años");
            }
        }
        
        Console.WriteLine("Las personas que son menores de edad son las siguientes: ");

        for(int f = 0; f < 5; f++)
        {
            if (años[f] < 18)
            {
                Console.WriteLine(nombre[f] + " con " + años[f] + " años");
            }
        }
    }
}