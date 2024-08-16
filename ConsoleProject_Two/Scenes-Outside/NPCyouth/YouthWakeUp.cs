using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside.NPCyouth
{
    public class YouthWakeUp : Scene
    {
        private string input;

        public YouthWakeUp(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("청년을 흔들어 봅니다...");
            Thread.Sleep(1000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("\"뭣무머뭐야?!...\" 화들짝 놀란 청년이 비몽사몽한 얼굴로 자리에서 튕겨져나오듯이 일어섭니다.");
            Console.WriteLine("그리고는 주변을 잠시 두리번 거리더니, \"아, 너였구나. 깜짝 놀랬잖아.\" 하고는, 도로 벤치에 털썩 앉았습니다.");
            Console.WriteLine();
            Console.WriteLine("\"뭐 필요한 거라도 있는거니?\" 청년이 피곤한 얼굴로 당신에게 말합니다.");
            Console.WriteLine();
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("무엇을 말하시겠습니까?");
            Console.WriteLine("1. 뭔가 달라고 한다.");
            Console.WriteLine("2. 할머니 집까지 호위를 부탁한다.");
            Console.WriteLine("4. 떠난다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.청년깨움);
                    break;
                case "2":
                    game.ChangeScene(SceneType.청년버그);
                    break;
                case "3":
                    game.ChangeScene(SceneType.청년호위);
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
