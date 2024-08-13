using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Outside
{
    public class Outside : Scene
    {
        public Outside(Game game) : base(game) { }

        public override void Enter() { }

        public override void Exit() { }
        public override void Input() { }

        public override void Render()
        {
            Console.WriteLine("~ 구현중 ~");
            Console.WriteLine("플레이 수고하셨습니다.");

            game.Over();
        }

        public override void Update() { }
    }
}
