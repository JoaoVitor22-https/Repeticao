class Program
{

    static void Main()
    {
        int contador = 1;

        Console.WriteLine("Digite um número: ");
        Convert.ToInt32(Console.ReadLine());

        while (contador >= -10)
        {
            Console.WriteLine(contador -= 1);


        }


    }
}



