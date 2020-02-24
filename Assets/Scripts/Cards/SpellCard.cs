using UnityEngine;
using System.Collections;

namespace AkeenDev
{
    [CreateAssetMenu(menuName = "Cards/Spell")]
    public class SpellCard : CardType
    {
        public override void OnSetType(CardViz viz)
        {
            viz.statsHolder.SetActive(false);
        }
    }
}