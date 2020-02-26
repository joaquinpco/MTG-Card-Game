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
                }

                Settings.gameManager.SetState(playerControlState);
                onPlayerControlState.Raise();
                return;
            }
        }
    }
}