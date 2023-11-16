using System;
namespace exercise
{
    public static class GameFactory
    {
        public static Game CreateGame(int gameNumber)
        {
            switch (gameNumber)
            {
                case 1:
                    return new BeachGame();
                case 2:
                    return new MousetrapGame();
                case 3:
                    return new SeaGame();
                case 4:
                    return new FishingGame();
                case 5:
                    return new PostmenGame();
                case 6:
                    return new SlideGame();
                default:
                    throw new ArgumentException("Вы неверно ввели номер");
            }
        }
    }
}
