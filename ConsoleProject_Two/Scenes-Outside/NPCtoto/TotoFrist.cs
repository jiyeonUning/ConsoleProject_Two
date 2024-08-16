using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside.NPCtoto
{
    public class TotoFrist : Scene
    {
        private string input;

        public TotoFrist(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("누군가의 형상이 보입니다...");
            Thread.Sleep(1000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("당신의 커다란 친구, 토토입니다. 토토는 당신 집의 바로 옆 주택에서 사는 청년이 마당에서 기르고 있는 개입니다.");
            Console.WriteLine("래브라도 리트리버 라는 종으로, 크고 귀여운 것이 특징입니다.");
            Console.WriteLine();
            Console.WriteLine("주인을 닮아 야행성인건지, 이른 아침임에도 곤히 잠들어 있는 모습입니다.");
            Console.WriteLine("이렇게나 사람이 가까이 왔는데도 태평하게 자는 모습을 보고 있자니, 지킴이 역할에는 영 재능이 없어보이네요.");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("어떻게 하시겠습니까?");
            Console.WriteLine("1. 흔들어서 깨운다.");
            Console.WriteLine("2. 산책갈까?");
            Console.WriteLine("3. 할머니 집까지 호위를 부탁한다.");
            Console.WriteLine("4. 떠난다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.마을);
                    break;
                case "0":
                    game.InvenIn();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.토토);
                    break;
            }
        }
    }
}
