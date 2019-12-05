using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HelloWorld
{
    public class GameController : MonoBehaviour
    {
        private Systems systems;
        // Use this for initialization
        void Start()
        {
            Contexts context=Contexts.sharedInstance;
            systems = new Feature("Systems").Add(new AddGameSystems(context));
            systems.Initialize();
        }

        // Update is called once per frame
        void Update()
        {
            systems.Execute();
            systems.Cleanup();
        }
    }
}

