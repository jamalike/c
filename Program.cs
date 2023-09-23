internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write(Multiplicar(7,3));
    }

    public static int Multiplicar(int m, int n)
    {
        int resultado = 0;
        for (int i=0; i< n; i++)
        {
            resultado += m;
        }
        return resultado;
    }
}