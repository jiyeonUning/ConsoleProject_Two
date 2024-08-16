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
                {//  0      1      2      3     4      5       6      7      8      9     10     11     12     13     14     15     16     17     18     19     20     21    22      23     24     25               
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }, // 0
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 1
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 2
                { false,  true, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false, false,  true,  true,  true,  true, false, false,  true, false }, // 3
                { false,  true, false, false,  true,  true,  true,  true,  true,  true,  true,  true, false,  true,  true,  true, false,  true,  true,  true,  true,  true,  true, false,  true, false }, // 4
                { false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true, false,  true,  true,  true, false,  true,  true,  true,  true,  true,  true, false,  true, false }, // 5
                { false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true, false }, // 6
                { false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true, false }, // 7
                { false,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true, false }, // 8
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 9
                { false,  true,  true, false,  true,  true,  true,  true,  true,  true,  true,  true, false,  true,  true,  true, false,  true,  true,  true,  true,  true,  true, false,  true, false }, // 10
                { false,  true, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false,  true,  true,  true,  true,  true,  true, false,  true, false }, // 11
                { false,  true, false, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false,  false,  true,  true,  true, true, false, false,  true, false }, // 12
                { false,  true,  true, false, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 13
                { false,  true,  true,  true, false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 14
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 15
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 16
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 17
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 18
                { false,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true, false }, // 19
                { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false }  // 20
                }; // 너무 넓게 잡아서 맵과 이동간의 괴리가 심한상태입니다

            playerPos = new Point(14, 10);
            gameObjects = new List<GameObject>();

            Place forest = new Place(this);
            forest.pos = new Point(23, 18);
            forest.simbol = '숲';
            forest.color = ConsoleColor.Green;
            gameObjects.Add(forest);

            Place hunter = new Place(this);
            hunter.pos = new Point(3, 4);
            hunter.simbol = '@';
            hunter.color = ConsoleColor.Yellow;
            gameObjects.Add(hunter);

            Place youth = new Place(this);
            youth.pos = new Point(22, 5);
            youth.simbol = '@';
            youth.color = ConsoleColor.Yellow;
            gameObjects.Add(youth);

            Place toto = new Place(this);
            toto.pos = new Point(13, 3);
            toto.simbol = '@';
            toto.color = ConsoleColor.Yellow;
            gameObjects.Add(youth);
        }

        public override void Enter()
        {
            Console.CursorVisible = false;

            Console.Clear();
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

        public override void Exit()
        {
            Console.CursorVisible = true;
        }

        public override void Input()
        {
            input = Console.ReadKey().Key;
        }

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
                    if (map[y, x]) // 해당부분의 문제로 보이는데,
                    {
                        Console.Write("  "); // 이 부분을 1칸으로 하면 아래 출력과 가로 넓이가 맞지 않아 맵에 제대로 구현되지 않고, 2칸으로 할 시 맵은 구현이 완료되나 이동에 문제가 생깁니다.
                    }
                    else
                    {
                        Console.Write("ㅁ");
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
