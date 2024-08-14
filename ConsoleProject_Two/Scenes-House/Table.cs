using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes
{
    public class Table : Scene
    {
        private string input;

        public Table(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("당신은 책상 위를 살핍니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("====================================================================================================");
            Console.WriteLine();
            Console.WriteLine("당신의 취미는 재봉입니다. 당신이 쓰고 있는 빨간색의 귀여운 두건 또한 당신의 작품이지요.");
            Console.WriteLine("재봉틀, 바늘꽂이, 가위 등.... 당신의 주 작업공간인 책상 위에는 여러 재봉 도구들이 가득하네요.");
            Console.WriteLine();
            Console.WriteLine("====================================================================================================");
            Console.WriteLine();
            Console.WriteLine("물건을 챙기시겠습니까? 보기의 선택지 중 딱 한 가지만 수행할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 가위를 챙긴다.");
            Console.WriteLine("2. 실과 바늘을 챙긴다.");
            Console.WriteLine("3. 아무것도 챙기지 않고 내려간다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.획득재봉가위);
                    break;
                case "2":
                    game.ChangeScene(SceneType.획득재봉키트);
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
                    game.ChangeScene(SceneType.책상);
                    break;
            }
        }
    }
}
