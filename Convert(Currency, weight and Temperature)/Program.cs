
class Program
{
    static void Main()
    {
        Console.WriteLine("Velg en operasjon: ");
        while (true)
        {
            Console.WriteLine("1. Currency");
            Console.WriteLine("2. Temperatur");
            Console.WriteLine("3. Weight");

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    convertCurrency();
                    break;
                case "2":
                    convertWeight();
                    break;
                case "3":
                    convertTemperatur();
                    break;
                default:
                    Console.WriteLine("Ugyldig tegn!");
                    break;
            }
        }
    }

    static void convertCurrency()
    {
        Console.WriteLine("1. Konverter fra NOK til USD");
        Console.WriteLine("2. Konverter fra USD til NOK");
        Console.WriteLine("3. Konverter fra NOK til EU");
        Console.WriteLine("4. Konverter fra EU til NOK");
        Console.WriteLine("5. Konverter fra NOK til British Pound");
        Console.WriteLine("6. Konverter fra British Pound til NOK");

        string Valutaalternativ = Console.ReadLine(); 

        Console.WriteLine("Beløp: ");
        double amount;
        if (!double.TryParse(Console.ReadLine(), out amount))
        {
            Console.WriteLine("Ugyldig beløp!");
            return;
        }

        double result;
        switch (Valutaalternativ)
        {
            case "1":
                result = amount * 0.093;
                Console.WriteLine($"{amount} NOK til USD er {result}");
                break;
            case "2":
                result = amount / 0.093;
                Console.WriteLine($"{amount} USD til NOK er {result}");
                break;
            case "3":
                result = amount * 0.11;
                Console.WriteLine($"{amount} NOK til EU er {result}");
                break;
            case "4":
                result = amount / 0.11;
                Console.WriteLine($"{amount} EU til NOK er {result}");
                break;
            case "5":
                result = amount * 0.09;
                Console.WriteLine($"{amount} NOK til Pound er {result}");
                break;
            case "6":
                result = amount / 0.09;
                Console.WriteLine($"{amount} Pound til NOK er {result}");
                break;
            default:
                Console.WriteLine("Ugyldig alternativ!");
                break;
        }
    }


    static void convertWeight()
    {
        Console.WriteLine("1. Konverter fra KG til pound");
        Console.WriteLine("2. Konverter fra pound til KG");

        string vektalternativ = Console.ReadLine();

        double vekt = Convert.ToDouble(Console.ReadLine());

        switch (vektalternativ)
        {
            case "1":
                double Pounds = vekt * 2.2046;
                Console.WriteLine($"{vekt} Pounds er {Pounds} Pounds");
                break;
            case "2":
                double KG = vekt / 2.2046;
                Console.WriteLine($"{vekt} KG er {KG} Pounds");
                break;
            default:
                Console.WriteLine("Ugyldig vekt!");
                break;
        }
    }


        static void convertTemperatur()
        {
            Console.WriteLine("1. Konverter fra Celsius til Fahrenheit");
            Console.WriteLine("2. Konverter fra Fahrenheit til Celsius");

            string tempreaturalternativ = Console.ReadLine();

            double temperatur = Convert.ToDouble(Console.ReadLine());

            switch (tempreaturalternativ)
            {
                case "1":
                    double celsius = (temperatur * 1.8000) + 32;
                    Console.WriteLine($"{temperatur} fahrenheit er {celsius} celsius");
                    break;
                case "2":
                    double fahrenheit = (temperatur / 1.8000) - 32;
                    Console.WriteLine($"{temperatur} celsius er {fahrenheit} fahrenheit");
                    break;
                default:
                    Console.WriteLine("Ugyldig temperatur!");
                    break;
            }
        }
    }