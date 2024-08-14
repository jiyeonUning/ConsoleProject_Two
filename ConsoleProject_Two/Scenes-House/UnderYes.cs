using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes
{
    public class UnderYes : Scene
    {
        private string input;

        public UnderYes(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("당신은 어머니의 부름에 따라 내려가보기로 하였습니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { input = Console.ReadLine(); }

        public override void Render()
        {
            Console.Clear();
            Console.WriteLine("================================================================================================");
            Console.WriteLine();
            Console.WriteLine("\"빨간 망토야! 좋은 아침이로구나.\" 당신의 어머니가 언제나처럼 온화한 미소로 당신을 반깁니다.");
            Console.WriteLine("하지만 그것은 곧 걱정스런 얼굴로 바뀌더니, 잠깐 머뭇거리시던 어머니는 어렵사리 입을 여셨습니다.");
            Console.WriteLine();
            Console.WriteLine("\"너도 알다시피, 지금 할머니께서 많이 편찮으시잖니. 혼자 사시다보니 더욱 걱정이 되는구나.\"");
            Console.WriteLine("\"엄마가 가기에는 요즘 장사일이 너무 바빠서...\"");
            Console.WriteLine();
            Console.WriteLine("\"빨간 망토야, 이 포도주와 빵이 든 바구니를 들고 할머니 댁에 잠시 다녀오지 않겠니?\"");
            Console.WriteLine("\"네가 말동무를 해주면 할머니께서도 분명 기뻐하실거야.\"");
            Console.WriteLine();
            Console.WriteLine("===============================================================================================");
            Console.WriteLine();
            Console.WriteLine("어떻게 하시겠습니까?");
            Console.WriteLine("1. 어머니의 말을 따른다.");
            Console.WriteLine("2. 어머니의 말을 따르지 않는다.");
            Console.WriteLine("0. 가지고 있는 물건들을 확인한다.");
            Console.Write("선택 : ");
        }

        public override void Update()
        {
            switch (input)
            {
                case "1":
                    game.ChangeScene(SceneType.동의함);
                    break;
                case "2":
                    game.ChangeEndingScene(EndingType.미식가);
                    break;
                case "0":
                    game.InvenIn();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("잘못 입력하셨습니다! 보기의 선택지에서 골라주세요. 스크립트를 다시 출력합니다...");
                    Thread.Sleep(2000);
                    game.ChangeScene(SceneType.아래층1);
                    break;
            }
        }
    }
}
