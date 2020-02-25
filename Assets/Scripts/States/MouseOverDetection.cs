using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

namespace AkeenDev.GameState
{
    [CreateAssetMenu(menuName ="Actions/MouseOverDetection")]
    public class MouseOverDetection : Action
    {
        public override void Execute(float d)
        {
            PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, results);

            foreach(RaycastResult result in results)
            {
                IClickable c = result.gameObject.GetComponentInParent<IClickable>();
                if(c != null)
                {
                    c.OnHighlight();
                }
            }
        }
    }
}