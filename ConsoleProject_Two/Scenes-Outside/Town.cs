using ConsoleProject_Two.TownMove;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleProject_Two.Scenes_Outside
{
    public class Town : Scene
    {
        private bool[,] map;
        private Point playerPos;
        private List<GameObject> gameObjects;
        private ConsoleKey input;

        public Town(Game game) : base(game)
        {
            map = new bool[,]
                {//  0      1      2      3     4      5       6      7      8      9     10     11     12     13     14     15     16     17     18     19     20     21     22     23     24     25     26               
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, // 0
                { false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 1
                { false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 2
                { false, false, false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false, false,  true,  true, false, false, false,  true,  true, false, false }, // 3
                { false, false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true, false, false,  true,  true,  true, false, false,  true,  true,  true,  true, false, false,  true,  true, false, false }, // 4
                { false, false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 5
                { false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false,  false, false, true,  true,  true,  true,  true, false, false }, // 6
                { false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false,  false, false, true,  true,  true,  true,  true, false, false }, // 7
                { false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 8
                { false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false,  true,  true,  true, false, false,  true,  true,  true,  true, false, false,  true,  true, false, false }, // 9
                { false, false, false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false, false,  true,  true, false, false, false,  true,  true, false, false }, // 10
                { false, false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 11
                { false, false, false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 12
                { false, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 13
                { false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 14
                { false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 15
                { false, false, false,  true,  true,  true,  true,  true,  true, false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 16
                { false, false, false,  true,  true,  true,  true,  true,  true, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 17
                { false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 18
                { false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false }, // 19
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }  // 20
                };

            playerPos = new Point(13, 10);
            gameObjects = new List<GameObject>();

            Place shop = new Place(this);
            shop.pos = new Point(10, 16);
            shop.simbol = '$';
            shop.color = ConsoleColor.Yellow;
            shop.destination = SceneType.상점; // 미구현

            Place forest = new Place(this);
            forest.pos = new Point(25, 18);
            forest.simbol = '숲';
            forest.color = ConsoleColor.Green;
            forest.destination = SceneType.숲물어봄;

            gameObjects.Add(shop);
            gameObjects.Add(forest);

            //==================================

            Place hunter = new Place(this);
            hunter.pos = new Point(4, 8);
            hunter.simbol = '사';
            hunter.color = ConsoleColor.Yellow;
            hunter.destination = SceneType.사냥꾼;

            Place youth = new Place(this);
            youth.pos = new Point(24, 7);
            youth.simbol = '청';
            youth.color = ConsoleColor.Yellow;
            youth.destination = SceneType.청년;

            Place toto = new Place(this);
            toto.pos = new Point(11, 4);
            toto.simbol = '토';
            toto.color = ConsoleColor.Yellow;
            toto.destination = SceneType.토토;

            gameObjects.Add(hunter);
            gameObjects.Add(youth);
            gameObjects.Add(toto);
        }
       
        public override void Enter()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine(" L O A D I N G . . . ");
            Thread.Sleep(700);
            Console.Clear();
            Console.WriteLine("=================================================================");
            Console.WriteLine("=                                                               =");
            Console.WriteLine("=----------- ---- --  마 을  탐 색  시 작 !  -- ---- -----------=");
            Console.WriteLine("=                                                               =");
            Console.WriteLine("=  자유롭게 돌아다니며, 클리어에 필요한 아이템을 수집해보세요.  =");
            Console.WriteLine("=                                                               =");
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine("                아 무  키 나  눌 러   시 작 하 기                ");
            Console.ReadKey();
            Console.Clear();
        }

        public override void Exit() { Console.CursorVisible = true; }

        public override void Input() { input = Console.ReadKey().Key; }

        public override void Render()
        {
            Console.Clear();
            PrintMap();
            PrintGameObject();
            PrintPlayer();
        }

        public override void Update()
        {
            Move();
            Interaction();
        }

        // =========================================================

        private void PrintMap()
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x])
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("▒");
                    }
                }
                Console.WriteLine();
            }
        }

        private void PrintGameObject()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                Console.SetCursorPosition(gameObject.pos.X, gameObject.pos.Y);
                Console.ForegroundColor = gameObject.color;
                Console.Write(gameObject.simbol);
                Console.ResetColor();
            }
        }

        private void PrintPlayer()
        {
            Console.SetCursorPosition(playerPos.X, playerPos.Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("@");
            Console.ResetColor();
        }

        //===============================================================================

        private void Move()
        {
            Point next = playerPos;

            switch (input)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    next = new Point(playerPos.X, playerPos.Y - 1);
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    next = new Point(playerPos.X, playerPos.Y + 1);
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    next = new Point(playerPos.X - 1, playerPos.Y);
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    next = new Point(playerPos.X + 1, playerPos.Y);
                    break;
            }

            if (map[next.Y, next.X])
            {
                playerPos = next;
            }
        }

        private void Interaction()
        {
            foreach (GameObject gameObject in gameObjects)
            {
                if (playerPos.X == gameObject.pos.X &&
                    playerPos.Y == gameObject.pos.Y)
                {
                    gameObject.Interaction();
                    if (gameObject.removeWhenInteract)
                    {
                        gameObjects.Remove(gameObject);
                    }
                    return;
                }
            }
        }
    }
}
