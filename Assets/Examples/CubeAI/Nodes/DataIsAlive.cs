using Plugins.xNodeUtilityAi.AbstractNodes;
using Plugins.xNodeUtilityAi.Framework;
using UnityEngine;

namespace Examples.CubeAI.Nodes {
    public class DataIsAlive : SimpleEntryNode {

        protected override int ValueProvider(AbstractAIComponent context) {
            return GetData<GameObject>().GetComponent<CubeEntity>().IsDead ? 0 : 1;
        }
    }
}