using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Endings
{
    public class NotDutifulDaughter : SceneEnding
    {
        public NotDutifulDaughter(Game game) : base(game) { }
        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine("당신은 침대를 살핍니다...");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("=========================================================================================");
            Console.WriteLine();
            Console.WriteLine("따듯한 햇살, 지저귀는 새들의 소리. 다시 단잠에 빠지기에 최적의 환경이네요.");
            Console.WriteLine("졸음을 참지 못한 당신은, 머리를 감싼 거추장스런 두건을 벗고 침대 위로 올라갑니다.");
            Console.WriteLine("아래서 당신을 애타게 부르는 소리는 포근한 햇볕과 잠자리에 뭍혀져만 갑니다...");
            Console.WriteLine();
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("아무 키나 입력하세요.");
            Console.ReadKey();
        }

        public override void Exit() { }

        public override void Input() { }
        public override void Render() { }
        public override void Update()
        {
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("=                                                =");
            Console.WriteLine("=      BAD ENDING 1, 잠자는 숲속의 불효녀        =");
            Console.WriteLine("=                                                =");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            Console.WriteLine("처 음 부 터   다 시   도 전 해 보 세 요 .");
            game.Over();
        }
    }
}
