class Comparador
{
    public static bool Compara(string val1, string val2)
    {
        return val1 == val2;
    }

    public static bool Compara(int val1, int val2)
    {
        return val1 == val2;
    }

    public static bool Compara(double val1, double val2)
    {
        return val1 == val2;
    }
}


class Program
{
    

    static void Main(string[] args)
    {
        bool resultadoString = Comparador.Compara("Marcus", "Marcus");
        Console.WriteLine(resultadoString);
        bool resultadoInt = Comparador.Compara(5, 5);
        Console.WriteLine(resultadoInt);
        bool resultadoDouble = Comparador.Compara(5.5, 5.5);
        Console.WriteLine(resultadoDouble);
    }
}