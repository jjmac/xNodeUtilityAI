﻿using Plugins.xNodeUtilityAi.AbstractNodes;
using Plugins.xNodeUtilityAi.Framework;

namespace Examples.CubeAI.Nodes {
    public class MaxHpCountNode : SimpleEntryNode {

        protected override int ValueProvider(AbstractAIComponent context) {
            CubeAIComponent cubeAiComponent = (CubeAIComponent) context;
            return cubeAiComponent.CubeEntity.MaxHp;
        }
        
    }
}