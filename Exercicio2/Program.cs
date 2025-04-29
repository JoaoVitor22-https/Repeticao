class Program
{

    static void Main()
    {
        Console.WriteLine("Digite um número: ");
        int informacao = Convert.ToInt32(Console.ReadLine());
        
        while (informacao >= 1)
        {
            Console.WriteLine(informacao++);
            

        }


    }
}



