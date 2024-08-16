using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside
{
    public class Outside : Scene
    {
        private string input;

        public Outside(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" L O A D I N G . . . ");
            Thread.Sleep(1000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("당신은 집을 나와 밖으로 발을 내딛습니다. 이렇게 이른 아침부터 밖으로 나온 것은 처음이라, 당신은 조금 낯섬을 느낍니다.");
            Console.WriteLine("아침의 마을을 둘러보다 길을 나서도 좋고, 바로 숲을 통해 할머니를 찾아뵈어도 괜찮을 것 같습니다.");
            Console.WriteLine("기분좋은 아침 바람이 불고 있네요. 좋은 여정의 시작입니다!");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("1. 앞으로 나아간다.");
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
                    game.ChangeScene(SceneType.바깥);
                    break;
            }
        }
    }
}
