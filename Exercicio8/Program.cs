class Program
{
    static void Main()
    {
        
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

       
        int resultado = 0;

        
        int contador = 1;
        while (contador <= 10)
        {
            resultado += numero; 
            contador++;
        }

        
        Console.WriteLine("O número multiplicado por 10 é: " + resultado);
    }
}