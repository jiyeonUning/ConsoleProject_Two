using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Endings
{
    public class Gourmet : SceneEnding
    {
        public Gourmet(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("어머니의 말에 고개를 젓습니다...");
            Thread.Sleep(2000);
        }

        public override void Exit() { }
        public override void Input() { }

        public override void Render()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("당신은 어머니의 부탁을 거절하였습니다. 10살한테 뭘 시키는거예요?");
            Console.WriteLine("어머니도 이해한다는 듯이 고개를 끄덕였습니다. \"그래, 네겐 아직 버거울 부탁이긴 했지.\"");
            Console.WriteLine();
            Console.WriteLine("\"그럼 이 바구니를 할머니께 가져다드릴 사람을 따로 찾아봐야겠구나...\"");
            Console.WriteLine("\"이른 아침부터 깨워 미안하구나. 배고프지? 아침 금방 차려줄게! 기다리렴.\"");
            Thread.Sleep(1000);
            Console.WriteLine("그렇게 말한 어머니는 금방 아침식사를 내어주셨습니다.");
            Console.WriteLine("갓 구운 베이컨, 계란. 그리고 신선한 우유와 빵... 푸짐하네요!");
            Console.WriteLine();
            Console.WriteLine("\"그럼 엄마는 옆집 청년에게 부탁해보러 다녀오마. 먹고 있으려무나.\"");
            Console.WriteLine("비록 혼자서 즐기는 식사지만, 당신은 집에서 즐겁게 아침식사를 할 수 있었습니다.");
            Console.WriteLine();
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("엔터키를 입력하세요.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("=                                         =");
            Console.WriteLine("=      BAD ENDING 2, 고독한 미식가        =");
            Console.WriteLine("=                                         =");
            Console.WriteLine("===========================================");
            Console.WriteLine();
            Console.WriteLine("처 음 부 터   다 시   도 전 해 보 세 요 .");
        }

        public override void Update() { game.Over(); }
    }
}
