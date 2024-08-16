﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_Two.TownMove
{
    public abstract class GameObject : IInteractable
    {
        public Game game;
        public Scene scene;

        public ConsoleColor color;
        public Point pos;
        public char simbol;
        public bool removeWhenInteract;

        public GameObject(Scene scene)
        {
            this.game = scene.game;
            this.scene = scene;
        }
        public abstract void Interaction();
    }
}
