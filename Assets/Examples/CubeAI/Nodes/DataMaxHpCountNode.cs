using Plugins.xNodeUtilityAi.AbstractNodes;
using Plugins.xNodeUtilityAi.Framework;
using UnityEngine;

namespace Examples.CubeAI.Nodes {
    public class DataMaxHpCountNode : SimpleEntryNode {

        protected override int ValueProvider(AbstractAIComponent context) {
            return GetData<GameObject>().GetComponent<CubeEntity>().MaxHp;
        }
        
    }
}