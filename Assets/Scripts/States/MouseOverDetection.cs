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
            List<RaycastResult> results = Settings.GetUIObjs();

            foreach (RaycastResult result in results)
            {
                IClickable c = result.gameObject.GetComponentInParent<IClickable>();

                if (c != null)
                {
                    c.OnHighlight();
                    break;
                }
            }
        }
    }
}