namespace ejer35
{
    public class program
    {
        public static void Main()
        {
            double precio, unidades;
            double porcentajeIva = 12, porcentajeDescuento = 5, limiteDescuento = 50000;
            double valorFactura=0;
            double precioBruto = 0;
            double subTotal = 0;
            double valordelDescuento=0;

            Console.WriteLine("por favor ingrese el precio");
            precio=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Por favor ingrese las unidades a facturar");
            unidades=Convert.ToDouble(Console.ReadLine());

            subTotal = (unidades * precio);
            precioBruto=(subTotal*(porcentajeIva/100))+subTotal;
            
            if(precioBruto>limiteDescuento)
            {
                valordelDescuento=precioBruto*(porcentajeDescuento/100);
                precioBruto = precioBruto - valordelDescuento;
            }
            Console.WriteLine(precioBruto);


        }
    }
}
