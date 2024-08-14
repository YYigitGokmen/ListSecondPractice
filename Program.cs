
public class Program
{

    public static void Main(string[] args)
    {
        List<string> coffeeOptions = new List<string>(5);

        //Kullanıcıdan tek soru bütün kahve isimleri alsaydık onları tek tek listenin içine yerleştiremezdik
        //ancak for döngüsü ile 5 kere sorarak listeyi oluşturdum.
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Lütfen {i + 1}. kahve ismini giriniz ");
            string selectedCoffeeOptions = Console.ReadLine();
            coffeeOptions.Add(selectedCoffeeOptions);
        }

        Console.WriteLine("Girilen Kahve İsimleri \n");
        foreach ( string coffeeOption in coffeeOptions )
        {
           
            Console.WriteLine(coffeeOption);
        }

    }


























}





















