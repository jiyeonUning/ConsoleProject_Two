using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside
{
    public class ForestIn : Scene
    {
        private string input;

        public ForestIn(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Thread.Sleep(500);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine();
            Console.WriteLine("숲에 진입 시 다시 마을로 돌아올 수 없습니다.");
            Console.WriteLine("          숲으로 들어가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("===============================================");
            Console.WriteLine();
            Console.WriteLine("1. 숲으로 들어간다.");
            Console.WriteLine("2. 마을을 더 둘러본다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.숲);
                    break;
                case "2":
                    game.ChangeScene(SceneType.마을);
                    break;
                case "0":
                    game.InvenIn();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.숲물어봄);
                    break;
            }
        }
    }
}
