namespace ConsoleProject_Two.Scenes
{
    public class Title : Scene // Scene 클래스의 정보값을 이어받는 자식 클래스 : 타이틀
    {
        public Title(Game game) : base(game) { }
        public override void Enter() { }
        public override void Exit() { }
        public override void Input() { Console.ReadKey(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("                  =====================================");
            Console.WriteLine("                  =                                   =");

            Console.Write("                  =        ~ ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("빨간");
            Console.ResetColor();
            Console.Write(" 망토");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" 이야기");
            Console.ResetColor();
            Console.WriteLine(" ~       =");

            Console.WriteLine("                  =                                   =");
            Console.WriteLine("                  =====================================");
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            Console.WriteLine("=                                                                       =");
            Console.WriteLine("=                       당신은 '빨간 망토' 입니다!                      =");
            Console.WriteLine("=  배드엔딩을 보지 않고 무사히 할머니 댁에 도착하게 되면 클리어입니다.  =");
            Console.WriteLine("=                              행운을 빌어요.                           =");
            Console.WriteLine("=                                                                       =");
            Console.WriteLine("=========================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("               계 속 하 려 면   아 무 키 나   누 르 세 요                ");

        }

        public override void Update()
        { game.ChangeScene(SceneType.내방_시작); }
    }
}
