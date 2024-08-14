using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes
{
    public class GetScissors : Scene
    {
        private string input;

        public GetScissors(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("가위를 집어듭니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("====================================================================================================");
            Console.WriteLine();
            Console.WriteLine("무엇이든 자를 수 있을 것만 같은 재봉 가위입니다. 산지 얼마 되지 않아 날이 매섭게 서 있습니다.");
            Console.WriteLine("끝이 뾰족하니 찔리지 않도록 주의합시다. 당신은 그것을 손수건으로 감싸 주머니에 안전히 넣어둡니다.");
            Console.WriteLine();
            Console.WriteLine("====================================================================================================");
            Console.WriteLine();
            Console.WriteLine("인벤토리의 다음과 같은 아이템을 추가합니다 : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("재봉가위 +");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("1. 아래로 내려간다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.아래층1);
                    break;
                case "0":
                    game.ChangeScene(SceneType.인벤토리);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.획득재봉가위);
                    break;
            }
        }
    }
}
