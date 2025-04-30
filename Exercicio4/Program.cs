class Program
{

    static void Main()
    {
        int contador = 2;

        Console.WriteLine("Digite um número: ");
        int N = Convert.ToInt32(Console.ReadLine());

        while (contador <= N)
        {
            Console.WriteLine(contador += 2);


        }


    }
}



