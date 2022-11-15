using homework3;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter dollar exchange rate:");
        decimal usd = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Enter euro exchange rate:");
        decimal euro = Convert.ToDecimal(Console.ReadLine());
        Converter converter = new Converter(usd, euro);
        while (true)
        {
            decimal uah = 0;
            decimal dollars = 0;
            decimal euros = 0;
            Console.WriteLine("What you want to do:");
            Console.WriteLine("1 Convert UAH to USD.");
            Console.WriteLine("2 Convert UAH to EURO.");
            Console.WriteLine("3 Convert USD to UAH.");
            Console.WriteLine("4 Convert EURO to UAH.");
            Console.WriteLine("5 back to menu");
            Console.Write("Enter number of operation:");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.Write("Enter UAH:");
                    uah = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("it will be " + converter.ConvertGrnToDollar(uah) + " usd");
                    break;
                case 2:
                    Console.Write("Enter UAH:");
                    uah = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("it will be " + converter.ConvertGrnToEuro(uah) + " euro");
                    break;
                case 3:
                    Console.Write("Enter dollars:");
                    dollars = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("it will be " + converter.ConvertDollarToGrn(dollars) + " uah");
                    break;
                case 4:
                    Console.Write("Enter euros:");
                    euros = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("it will be " + converter.ConvertEuroToGrn(euros) + " uah");
                    break;
                default:
                    return;
            }
        }
    }
}