namespace pz14_3
{
    //ипсользовался паттерн декоратор
    class Program
    {
        
        static void Main(string[] args)
        {
            Hotel hotel1 = new OrenHotel();
            hotel1 = new WifiHotel(hotel1); // итальянская пицца с томатами
            Console.WriteLine($"Название: {hotel1.Name}");
            Console.WriteLine($"Цена: {hotel1.GetCost()}" );

            Hotel hotel2 = new OrenHotel();
            hotel2 = new WifiHotel(hotel2);// итальянская пиццы с сыром
            Console.WriteLine($"Название: {hotel2.Name}");
            Console.WriteLine($"Цена: {hotel2.GetCost()}");

            Hotel hotel3 = new MoscowHotel();
            hotel3 = new WifiHotel(hotel3);
            hotel3 = new CarHotel(hotel3);// болгарская пиццы с томатами и сыром
            Console.WriteLine($"Название: {hotel3.Name}");
            Console.WriteLine($"Цена: {hotel3.GetCost()}");

            Console.ReadLine();
        }
    }
}
