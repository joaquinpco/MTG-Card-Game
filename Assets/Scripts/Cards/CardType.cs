using UnityEngine;
using System.Collections;

namespace AkeenDev
{
    public abstract class CardType : ScriptableObject
    {
        public string typeName;
        public abstract void OnSetType(CardViz viz);
    }
}