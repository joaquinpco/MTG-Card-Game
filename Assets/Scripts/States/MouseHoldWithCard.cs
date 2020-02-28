using UnityEngine;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace AkeenDev.GameState
{
    [CreateAssetMenu(menuName = "Actions/MouseHoldWithCard")]
    public class MouseHoldWithCard : Action
    {
        public State playerControlState;
        public SO.GameEvent onPlayerControlState;
        public CardVariable currentCard;
        public override void Execute(float d)
        {
            bool mouseIsDown = Input.GetMouseButton(0);
            
            //Check when drop card
            if(!mouseIsDown)
            {
                List<RaycastResult> results = Settings.GetUIObjs();

                foreach(RaycastResult r in results)
                {
                    //Check x droppable area.
                    GameElements.Area area = r.gameObject.GetComponentInParent<GameElements.Area>();
                    
                    if(area != null)
                    {
                        area.OnDrop();
                        break;
                    }
                }

                currentCard.value.gameObject.SetActive(true);
                currentCard.value = null;

                Settings.gameManager.SetState(playerControlState);
                onPlayerControlState.Raise();
                return;
            }
        }
    }
}