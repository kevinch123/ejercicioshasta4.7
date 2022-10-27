namespace ejer216
{
    public class programa
    {
        public static void Main()
        {
            int contador;
            int limite;
            int sumatoria;
            limite = 10;
            sumatoria = 0;
            contador = 1;
            for (contador = 1; contador <= limite; contador++)
            {
                sumatoria = sumatoria + contador;
            }
            Console.WriteLine($"LA SUMATORIA ES :{sumatoria}");
        }
    }
}
