namespace ejer45
{
    public class program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int anyo = 0;
            bool bisiesto=false;

            Console.WriteLine("Ingrese el dia");
            dia = Convert.ToInt32(Console.ReadLine());
            if (dia<0)
            {
                Console.WriteLine("dia invalido");
            }
            Console.WriteLine("Ingrese el mes");
            mes = Convert.ToInt32(Console.ReadLine());
            
            if(mes==1||mes==3||mes==5||mes==10||mes==12||mes==8||mes==7)
            {
                if(dia>31)
                {
                    Console.WriteLine("el dia no es valido");
                }
            }
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11 )
            {
                if (dia > 30)
                {
                    Console.WriteLine("el dia no es valido");
                }
            }

            Console.WriteLine("Ingrese el año");
            anyo=Convert.ToInt32(Console.ReadLine());

            bisiesto = (anyo % 4 == 0);

            if (mes==2)
            {
                if (dia>29 && bisiesto)
                {
                    Console.WriteLine("el dia no es valido");
                }
                else if (dia>28 &&!bisiesto)
                {
                    Console.WriteLine("el dia no es valido");
                }
            }
            
            DateTime mifecha=new DateTime(anyo,mes,dia);
            mifecha = mifecha.AddDays(1);

            Console.WriteLine(mifecha);
            

        }
        


    }
}