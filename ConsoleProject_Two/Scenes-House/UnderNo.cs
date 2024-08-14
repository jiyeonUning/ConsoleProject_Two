namespace ConsoleProject_Two.Scenes
{
    public class UnderNo : Scene
    {
        private string input;

        public UnderNo(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("당신은 어머니의 부름을 무시하기로 했습니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine("잠깐 내려가지 않는다고 해서 화를 내시진 않을거예요.");
            Console.WriteLine("당신은 2층에 위치한 자신의 아기자기한 방을 바라봅니다.");
            Console.WriteLine();
            Console.WriteLine("=================================================================");
            Console.WriteLine();
            Console.WriteLine("무엇을 하시겠습니까?");
            Console.WriteLine("1. 침대를 살핀다.");
            Console.WriteLine("2. 책상 위를 살핀다.");
            Console.WriteLine("3. 그냥 내려간다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeEndingScene(EndingType.불효녀);
                    break;
                case "2":
                    game.ChangeScene(SceneType.책상);
                    break;
                case "3":
                    game.ChangeScene(SceneType.아래층1);
                    break;
                case "0":
                    game.ChangeScene(SceneType.인벤토리);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.아래층2);
                    break;
            }
        }
    }
}
