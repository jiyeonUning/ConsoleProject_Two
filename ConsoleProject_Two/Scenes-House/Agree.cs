namespace ConsoleProject_Two.Scenes
{
    public class Agree : Scene
    {
        private string input;

        public Agree(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("어머니의 말에 고개를 끄덕입니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine();
            Console.WriteLine("\"정말 고맙구나! 할머니께서도 분명 기뻐하실거야.\" 어머니가 행복하게 웃었습니다.");
            Console.WriteLine();
            Console.WriteLine("\"이미 알고 있겠지만, 할머니 댁은 숲속으로 향하는 오솔길을 쭉 따라가면 나온단다.\"");
            Console.WriteLine("\"명심하려무나. 다른 길로 새지 말고, 곧장 할머니 댁으로 가도록 하렴. 모르는 사람은 따라가면 안된다!\"");
            Console.WriteLine();
            Console.WriteLine("어머니가 당부하자, 당신은 걱정할 것 없다는 듯 어깨를 으쓱합니다.");
            Console.WriteLine("그 늠름한 모습을 보던 어머니는 한숨을 한번 푸욱 쉬시고는, 당신에게 묵직한 바구니를 건네주었습니다.");
            Console.WriteLine();
            Console.WriteLine("\"잘 다녀오려무나.\"");
            Console.WriteLine();
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine();
            Console.WriteLine("집을 나섭니까?");
            Console.WriteLine("1. 다녀오겠습니다!");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.바깥);
                    break;
                case "0":
                    game.ChangeScene(SceneType.인벤토리);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.동의함);
                    break;
            }
        }
    }
}
