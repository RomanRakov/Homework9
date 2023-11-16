using System;
namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение");
            var russia = new Team("Россия");
            var france = new Team("Франция");
            var china = new Team("Китай");
            var kazakhstan = new Team("Казахстан");
            russia.AddGame(GameFactory.CreateGame(1));
            france.AddGame(GameFactory.CreateGame(2));
            china.AddGame(GameFactory.CreateGame(3));
            kazakhstan.AddGame(GameFactory.CreateGame(4));        
            russia.PlayGames();
            france.PlayGames();
            china.PlayGames();
            kazakhstan.PlayGames();
            var customGame = new CustomGame();
            russia.AddGame(customGame);
            russia.PlayGames();
            Console.ReadKey();  
        }
    }
}
