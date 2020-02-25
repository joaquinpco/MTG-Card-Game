using UnityEngine;
using System.Collections;

namespace AkeenDev
{
    public abstract class CardType : ScriptableObject
    {
        public string typeName;
        public virtual void OnSetType(CardViz viz)
        {
            Element t = Settings.GetResourcesManager().typeElement;
            CardVizProperties type = viz.GetProperty(t);
            type.text.text = typeName;
        }

    }
}