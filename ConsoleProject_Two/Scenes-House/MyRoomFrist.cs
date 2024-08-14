using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleProject_Two.Scenes
{
    public class MyRoomFrist : Scene
    {
        private string input; // 선택지 선택

        public MyRoomFrist(Game game) : base(game) { }
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
            Console.WriteLine("================================================================================================");
            Console.WriteLine();
            Console.WriteLine("\"빨간 망토야, 어서 내려와보렴!\"");
            Console.WriteLine("이른 아침부터, 무슨일인지 어머니가 아래층에서 부터 당신을 부르고 있습니다. 무슨 일인 걸까요?");
            Console.WriteLine("바로 내려가시겠습니까?");
            Console.WriteLine();
            Console.WriteLine("================================================================================================");
            Console.WriteLine();
            Console.WriteLine("1. 내려간다");
            Console.WriteLine("2. 내려가지 않는다.");
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
                case "2":
                    game.ChangeScene(SceneType.아래층2);
                    break;
                case "0":
                    game.ChangeScene(SceneType.인벤토리);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.내방_시작);
                    break;
            }
        }
    }
}
