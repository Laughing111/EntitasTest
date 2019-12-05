using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace HelloWorld
{
    public class LogSystem : ReactiveSystem<GameEntity>
    {
        public LogSystem(Contexts context) : base(context.game)
        {
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                Debug.Log(entity.helloWorldLog.message);
            }
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasHelloWorldLog;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.HelloWorldLog);
        }
    }
}

