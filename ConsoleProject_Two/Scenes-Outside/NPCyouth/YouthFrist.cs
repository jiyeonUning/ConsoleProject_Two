using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside.NPCyouth
{
    public class YouthFrist : Scene
    {
        private string input;

        public YouthFrist(Game game) : base(game) { }

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
            Console.WriteLine("당신 집의 바로 옆 주택에서 살고 있는 청년입니다. 키가 크지만, 항상 자세가 구부정해 멀리서보면 어쩐지 작아보입니다.");
            Console.WriteLine("구부정한 자세로 컴퓨터 자판을 두드리며 검은 화면에 꼬불한 글자를 입력하던 것이 당신이 기억하는 청년의 모습이입니다.");
            Console.WriteLine();
            Console.WriteLine("하지만, 오늘은 무슨일인지 이렇게 이른 시간에도 일어나 있네요. 손에도 아무것도 들고 있지 않습니다.");
            Console.WriteLine("졸고 있는 것만 빼면, 매우 한가해보입니다.");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("어떻게 하시겠습니까?");
            Console.WriteLine("1. 흔들어서 깨운다.");
            Console.WriteLine("2. \" 어? \" ");
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
                case "2":
                    game.ChangeScene(SceneType.마을);
                    break;
                case "3":
                    game.ChangeScene(SceneType.마을);
                    break;
                case "4":
                    game.ChangeScene(SceneType.마을);
                    break;
                case "0":
                    game.InvenIn();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.청년);
                    break;
            }
        }
    }
}
