using System.Security.Cryptography;

namespace ejer47
{
    public class program
    {
        public static void Main()
        {
            int numb1;
            int numb2;
            bool divisible=false;

            Console.WriteLine("El primer numero sera tomado para saber si es divisible por el numero 2");

            Console.WriteLine("Ingrese el numero 1");
            numb1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el numero 2");
            numb2 = Convert.ToInt32(Console.ReadLine());

            divisible = (numb1 % numb2 == 0);


                if (numb1%numb2==0)
                {
                    Console.WriteLine("El numero 1 es divisible por el numero 2");
                }
                else
            {
                Console.WriteLine("el  numero 1 no es divisble por el numero 2");
            }
 






        }
    }
}
    
