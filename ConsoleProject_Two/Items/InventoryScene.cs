using ConsoleProject_Two.Items;

namespace ConsoleProject_Two.Iventory
{
    public class InventoryScene : Scene
    {
        private string input;

        public InventoryScene(Game game) : base(game)  {  }

        public override void Enter() { }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==============================================");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("                빨 간");
            Console.ResetColor();
            Console.WriteLine("  망 토");

            Console.WriteLine();
            Console.WriteLine($"          : 소지하고 있는 아이템 :");
                    Console.Write($"{Inventory.ShowAllItems(true)}");
            // 인벤토리 출력부터 막히는데 그 이상을 시도하는건 역시 무모하겠죠?................
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===============================================");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("돌 아 가 려 면   9 번  키 를   눌 러 주 세 요 .");
        }

        public override void Update()
        {
            switch (input)
            {
                case "9":
                    game.InvenOut();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 9번을 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(1000);
                    game.ChangeScene(SceneType.인벤토리);
                    break;
            }
        }
    }
}
