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
        public AkeenDev.GameElements.GE_Logic cardsDownLogic;
        public override void Execute()
        {
            if(card.value != null)
            {
                if(card.value.viz.card.cardType == creatureType)
                {
                    Settings.SetParentForCard(card.value.transform, areaGrid.value.transform);
                    card.value.gameObject.SetActive(true);
                    card.value.currentLogic = cardsDownLogic;
                }
            }
        }
    }
}