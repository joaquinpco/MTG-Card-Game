using UnityEngine;
using System.Collections;

namespace AkeenDev.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/My Hands Card")]
    public class HandCard : GE_Logic
    {
        public CardVariable currentCard;
        public SO.GameEvent onCurrentCardSelected;

        //Add State to delete cards one by one
        public AkeenDev.GameState.State holdingCard;

        public override void OnClick(CardInstance cardInstance)
        {
            currentCard.Set(cardInstance);
            Settings.gameManager.SetState(holdingCard);
            onCurrentCardSelected.Raise();
        }

        public override void OnHighlight(CardInstance cardInstance)
        {
        }
    }
}