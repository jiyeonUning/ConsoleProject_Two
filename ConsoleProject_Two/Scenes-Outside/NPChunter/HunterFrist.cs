using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside.NPChunter
{
    public class HunterFrist : Scene
    {
        private string input;

        public HunterFrist(Game game) : base(game) { }

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
            Console.WriteLine("드문드문 당신의 마을에 찾아와, 짐승의 가죽이나 고기를 팔곤 하던 떠돌이 사냥꾼 아저씨 입니다.");
            Console.WriteLine("좀 험악하게 생기고, 쇳내가 나는 걸 빼면 참 좋은 아저씨입니다.");
            Console.WriteLine("당신은 사냥꾼을 만날 때 마다 정체모를 육포를 맛있게 받아먹었던 추억을 떠올립니다.");
            Console.WriteLine();
            Console.WriteLine("하지만, 오늘은 어쩐 일인지 가방도 가벼워보이고, 무엇보다 빈 손인 것 같습니다.");
            Console.WriteLine("당신이 코앞까지 다가온 것을 아는 건지, 모르는 건지. 사냥꾼은 당신에게 눈길 한 번 주지 않고 총구만 손질하고 있습니다.");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("말을 거시겠습니까?");
            Console.WriteLine("1. 먼저 인사한다.");
            Console.WriteLine("2. 육포를 달라고 한다.");
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
                    game.ChangeScene(SceneType.사냥꾼);
                    break;
            }
        }
    }
}
