using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.Scenes
{
    public class UnderYes : Scene
    {
        private string input; // 선택지 선택

        public UnderYes(Game game) : base(game) { }
        public override void Enter() { }
        public override void Exit() { }
        public override void Input() { Console.ReadLine(); }
    }
}
