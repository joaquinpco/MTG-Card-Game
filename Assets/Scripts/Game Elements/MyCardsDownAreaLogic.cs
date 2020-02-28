using UnityEngine;
using System.Collections;

namespace AkeenDev.GameElements
{
    [CreateAssetMenu(menuName = "Areas/DownwhenHoldingCard")]
    public class MyCardsDownAreaLogic : AreaLogic
    {
        public CardVariable card;
        public CardType creatureType;
        public SO.TransformVariable areaGrid;
        public override void Execute()
        {
            if(card.value != null)
            {
                if(card.value.viz.card.cardType == creatureType)
                {
                    card.value.transform.SetParent(areaGrid.value.transform);
                    card.value.transform.localPosition = Vector3.zero;
                    card.value.transform.localScale = Vector3.one;
                    card.value.gameObject.SetActive(true);
                }
            }
        }
    }
}