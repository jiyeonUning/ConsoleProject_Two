using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes_Inside
{
    public class Forest : Scene
    {
        public Gourmet(Game game) : base(game) { }

        public override void Enter()
        {
            Console.Clear();
            Console.WriteLine(" L O A D I N G . . . ");
            Thread.Sleep(700);
            Console.Clear();
        }

        public override void Exit() { }

        public override void Input() { }

        public override void Render() { }

        public override void Update()
        {
            Console.WriteLine("      ~ 개발 진행중 ~");
            Console.WriteLine(" 플레이 해주셔서 감사합니다 ");
            Console.WriteLine();
            game.Over();
        }
    }
}
