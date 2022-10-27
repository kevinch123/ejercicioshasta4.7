namespace ejer24
{
    public class program
    {
        public static void Main()
        {
            int Num1;
            int Num2;
            int Num3;
            int Num4;
            int Sum;
            double Media;
            int producto;
            Console.WriteLine("ingrese el primer numero");
            Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero");
            Num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tercer numero");
            Num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el cuarto numero");
            Num4 = int.Parse(Console.ReadLine());

            producto = Num1 * Num2 * Num3 * Num4;
            Sum = Num1 + Num2 + Num3 + Num4;
            Media = Sum / 4;

            Console.WriteLine($"El resultado de el producto de los cuatro numeros es:{producto}");
            Console.WriteLine($"El resultado de la suma de los cuatro numeros es :{Sum}");
            Console.WriteLine($"El resultado de la media es :{Media}");
        }
    }
}
