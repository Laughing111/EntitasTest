using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace HelloWorld
{
    public class InitSystem : IInitializeSystem
    {

        private readonly GameContext gameContext;
        public InitSystem(Contexts contexts)
        {
            gameContext = contexts.game;
        }
        public void Initialize()
        {
            gameContext.CreateEntity().AddHelloWorldLog("Hello World");
        }
    }
}

