namespace ConsoleProject_Two.Iventory
{
    public class Inventory : SceneItem
    {
        private string input;

        public Inventory(Game game) : base(game) { }
        public override void Enter()
        {
            game.InvenIn();
        }

        public override void Exit() { }
        public override void Input() { Console.ReadLine(); }

        public override void Render()
        {
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
            Console.WriteLine($" {itemName,-6}");
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
                    game.ChangeItemScene(ItemType.인벤토리);
                    break;
            }
        }
    }
}
