namespace ejer23
{
    public class program
    {
        public static void Main()

        {
            //
            int Num,doble,final;
            Console.WriteLine("digite un numero porfavor, este numero se doblara y se  multiplicara por 25");
            Num = Convert.ToInt32(Console.ReadLine());

            doble = Num * 2;
            final = doble * 25;

            Console.WriteLine($"El resultado final sera:{final}");



        }
    }
}