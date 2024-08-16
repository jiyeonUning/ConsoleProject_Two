using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.TownMove
{
    internal class Place : GameObject
    {
        public SceneType destination;

        public Place(Scene scene) : base(scene) { }
        public override void Interaction() { game.ChangeScene(destination); }
    }
}
