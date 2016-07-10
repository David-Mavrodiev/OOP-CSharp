namespace Build_It_Daegon
{
    using Build_It_Daegon.Buildings;
    using Build_It_Daegon.Common;
    using Build_It_Daegon.Interfaces;
    using Build_It_Daegon.Resources;
    using System;
    using System.Threading;
    class Start
    {

        const int Map_Size_X = 20, Map_Size_Y = 20;
        static Electricity electricity = new Electricity(0);
        static Food food = new Food(0);
        static Happiness happiness = new Happiness();
        static Health health = new Health(0);
        static Money money = new Money(0);
        static Population population = new Population(0);
        static Security security = new Security(0);
        static Water water = new Water(0);

        static int cursorX = Map_Size_X / 2, cursorY = Map_Size_Y / 2;
        static int[,] map = new int[Map_Size_X, Map_Size_Y];
        static Building[] buildings = new Building[2000];
        static int countOfBuildings = 0;
        static int residenceBuildingsCount = 0; // Used when generating money
        static ConsoleKeyInfo keyInfo;
        static int sizeOfEnemy = 1;
        static int timer = 0;
        static bool lose = false;
        static Random random = new Random();

        static void drawMap(int[,] map, Building[] buildings, bool changed)
        {
            int x, y, i;
            if (changed)
            {
                for (y = 0; y < Map_Size_Y; y++)
                {
                    for (x = 0; x < Map_Size_X; x++)
                    {
                        if (map[x, y] == 0)
                        {
                            Console.Write(".");
                        }
                        else
                        {
                            Console.Write("@");
                        }
                    }
                    Console.WriteLine();
                }
            }
            for (i = 0; i < countOfBuildings; i++)
            {
                if (changed) {
                    Console.SetCursorPosition(buildings[i].Position.x, buildings[i].Position.y);
                    switch (buildings[i].Color)                                             // Painting buildings
                    {                                                                       //
                        case Color.Blue: Console.ForegroundColor = ConsoleColor.Blue;       //
                            break;                                                          //
                        case Color.Red: Console.ForegroundColor = ConsoleColor.Red;         //
                            break;                                                          //
                        case Color.Green: Console.ForegroundColor = ConsoleColor.Green;     //
                            break;                                                          //
                        case Color.Yellow: Console.ForegroundColor = ConsoleColor.Yellow;   //
                            break;                                                          //
                        case Color.Gray: Console.ForegroundColor = ConsoleColor.Cyan;       //
                            break;                                                          //
                        case Color.Pink: Console.ForegroundColor = ConsoleColor.Magenta;    //
                            break;                                                          //
                        default:                                                            //
                            break;                                                          //
                    }                                                                       //
                    Console.WriteLine(buildings[i].Letter);
                    Console.ForegroundColor = ConsoleColor.Gray;                            // Change back to default color
                }
                buildings[i].ManageResources();
                
            }
            happiness.EvaluateHappiness(food, security, electricity, health, water); // So we can generate money
            population.CalculatePopulation(happiness, residenceBuildingsCount);      //
            money.GenerateMoney(population);                                         //
        }
        static void EnemyMove(ref int[,] map, ref Building[] buildings, int size)
        {
            int x, y;
            for (y = 0; y < Map_Size_Y; y++)
            {
                for (x = 0; x < Map_Size_X; x++)
                {
                    if (map[x, y] > 0)
                    {
                        if (x - 1 >= 0 && map[x - 1, y] == 0 && random.Next(0, security.Amount / 10) == 0)
                        {
                            map[x - 1, y] = map[x - 1, y] + 1;
                        }
                        if (x + 1 < Map_Size_X && map[x + 1, y] == 0 && random.Next(0, security.Amount / 10) == 0)
                        {
                            map[x + 1, y] = map[x + 1, y] + 1;
                        }
                        if (y - 1 >= 0 && map[x, y - 1] == 0 && random.Next(0, security.Amount / 10) == 0)
                        {
                            map[x, y - 1] = map[x, y - 1] + 1;
                        }
                        if (y + 1 < Map_Size_Y && map[x, y + 1] == 0 && random.Next(0, security.Amount / 10) == 0)
                        {
                            map[x, y + 1] = map[x, y + 1] + 1;
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            map[19, 19] = 1;
            int haveInput = 0;
            // choose difficulty level
            Console.WriteLine("Choose difficulty (Easy, Medium or Hard)");
            string d = Console.ReadLine().ToLower();                     // toLower just in case
            Console.Clear();                                             // Remove the Choose difficulty text
            Difficulty difficult = new Difficulty();
            switch (d)
            {
                case "easy": difficult = Difficulty.Easy; break;
                case "medium": difficult = Difficulty.Medium; break;
                case "hard": difficult = Difficulty.Hard; break;
            }

            if (difficult == Difficulty.Easy)
            {
                timer = 100 * 2;
            }
            else if (difficult == Difficulty.Medium)
            {
                timer = 70 * 2;
            }
            else if (difficult == Difficulty.Hard)
            {
                timer = 50;
            }
            drawMap(map, buildings, true);
            while (!lose)
            {
                Thread.Sleep(timer);
                if (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey();

                    if (Convert.ToString(keyInfo.Key) == "Enter")
                    {
                        Console.Clear();
                        Console.WriteLine("What kind of building you want to build?");
                        Console.WriteLine("a) Electricity factory                  ");
                        Console.WriteLine("b) Food factory                         ");
                        Console.WriteLine("c) Water factory                        ");
                        Console.WriteLine("d) Hospital                             ");
                        Console.WriteLine("e) Residence                            ");
                        Console.WriteLine("f) Security                             ");
                        Console.WriteLine("Write only letter a, b, c, d, e or f    ");
                        string letter = Console.ReadLine();
                        Position position = new Position();

                        position.x = cursorX;
                        position.y = cursorY;

                        switch (letter)
                        {
                            case "a": buildings[countOfBuildings] = new ElectricityFactory('E', position, Color.Blue, ref electricity); break;
                            case "b": buildings[countOfBuildings] = new FoodFactory('F', position, Color.Gray, ref electricity, ref food); break;
                            case "c": buildings[countOfBuildings] = new WaterFactory('W', position, Color.Green, ref electricity, ref water); break;
                            case "d": buildings[countOfBuildings] = new HospitalBuilding('H', position, Color.Pink, 1, ref health, ref electricity); break;
                            case "e": buildings[countOfBuildings] = new ResidenceBuilding('R', position, Color.Yellow, 1, ref security, ref health, ref electricity, ref food, ref water, ref money); residenceBuildingsCount++; break;
                            case "f": buildings[countOfBuildings] = new SecurityBuilding('S', position, Color.Red, 1, ref security, ref electricity); break;
                        }
                        countOfBuildings++;
                        drawMap(map, buildings, true);
                    }
                    if (Convert.ToString(keyInfo.Key) == "LeftArrow")
                    {
                        cursorX--;
                    }
                    if (Convert.ToString(keyInfo.Key) == "RightArrow")
                    {
                        cursorX++;
                    }
                    if (Convert.ToString(keyInfo.Key) == "UpArrow")
                    {
                        cursorY--;
                    }
                    if (Convert.ToString(keyInfo.Key) == "DownArrow")
                    {
                        cursorY++;
                    }
                    if (cursorX < 0)
                    {
                        cursorX = 0;
                    }
                    if (cursorX >= Map_Size_X)
                    {
                        cursorX = Map_Size_X - 1;
                    }
                    if (cursorY < 0)
                    {
                        cursorY = 0;
                    }
                    if (cursorY >= Map_Size_Y)
                    {
                        cursorY = Map_Size_Y - 1;
                    }

                    Console.Clear();
                    keyInfo = new ConsoleKeyInfo();
                    EnemyMove(ref map, ref buildings, sizeOfEnemy);
                    sizeOfEnemy++;
                    drawMap(map, buildings, true);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("Electricity: {0} Food: {1} Water: {2} Happiness: {3} \nHealth: {4} Money: {5} Population: {6} Security: {7}",
                    electricity.Amount, food.Amount, water.Amount, happiness.Amount, health.Amount, money.Amount, population.Amount, security.Amount);
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.WriteLine("X");
                    haveInput = 1;
                }
                else
                {
                    drawMap(map, buildings, false);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("Electricity: {0} Food: {1} Water: {2} Happiness: {3} \nHealth: {4} Money: {5} Population: {6} Security: {7}",
                    electricity.Amount, food.Amount, water.Amount, happiness.Amount, health.Amount, money.Amount, population.Amount, security.Amount);
                    Console.SetCursorPosition(cursorX, cursorY);
                    Console.WriteLine("X");
                }
            }
        }
    }
}