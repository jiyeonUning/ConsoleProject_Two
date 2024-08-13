using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes
{
    public class GetSew : Scene
    {
        private string input;

        public GetSew(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("실과 바늘을 집어듭니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.WriteLine("====================================================================================================");
            Console.WriteLine();
            Console.WriteLine("비록 당신 손만한 크기의 조그만 재봉키트이지만... 아무튼 주머니에 소중히 넣어둡니다.");
            Console.WriteLine("실이 모자라지 않는 한, 천과 천 사이를 꿰맬 때 유용히 사용할 수 있을 것 같습니다.");
            Console.WriteLine();
            Console.WriteLine("====================================================================================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("미니 재봉 키트 (가위 미포함) +");
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
                    game.ChangeScene(SceneType.획득재봉키트);
                    break;
            }
        }
    }
}
