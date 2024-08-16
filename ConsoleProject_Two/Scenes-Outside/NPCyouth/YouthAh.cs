using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside.NPCyouth
{
    public class YouthAh : Scene
    {
        private string input;

        public YouthAh(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("어?...");
            Thread.Sleep(1000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("==================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("당신은 이전에, 청년의 근처에서 '어?' 하는 소리가 들릴 때 마다 어쩐지 다급해 하던 그의 모습을 떠올렸습니다.");
            Console.WriteLine("...이게 과연 효과가 있을까요? 시험삼아, 당신은 졸고있는 청년의 가까이에서 그 흉내를 내보았습니다.");
            Console.WriteLine();
            Console.WriteLine("그러자 청년은 곧,");
            Console.WriteLine();
            Console.WriteLine("==================================================================================================================");
            Thread.Sleep(2300);
            Console.Clear();
            Console.WriteLine("==================================================================================================================");
            Console.WriteLine();
            Console.WriteLine("\"-으아악!\"");
            Console.WriteLine("단말마같은 비명과 함께, 졸고 있던 사람이라곤 생각할 수 없을 만큼 눈을 번쩍 뜨더니,");
            Console.WriteLine("이내 왼 손가락을 다급하게 움직이며 잠에서 완전히 깨어납니다.");
            Console.WriteLine("당신이 청년을 측은이 바라보고 있을 때, 그 시선을 느낀 청년이 헛기침을 하고는 당신에게 말합니다.");
            Console.WriteLine("\"크흠, 큼. ...뭐 필요한 거라도 있는거니?\"");
            Console.WriteLine();
            Console.WriteLine("==================================================================================================================");
            Console.WriteLine("무엇을 말하시겠습니까?");
            Console.WriteLine("1. 뭔가 달라고 한다.");
            Console.WriteLine("2. 할머니 집까지 호위를 부탁한다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
            Console.Write("다음 선택지는 미완성입니다.");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.청년버그);
                    break;
                case "2":
                    game.ChangeScene(SceneType.청년버그);
                    break;
                case "0":
                    game.InvenIn();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.청년버그);
                    break;
            }
        }
    }
}
