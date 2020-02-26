using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections.Generic;

namespace AkeenDev.GameState
{
    [CreateAssetMenu(menuName = "Actions/OnMouseClick")]
    public class OnMouseClick : Action
    {
        public override void Execute(float d)
        {
            if (Input.GetMouseButtonDown(0))
            {
                List<RaycastResult> results = Settings.GetUIObjs();

                foreach (RaycastResult result in results)
                {
                    IClickable c = result.gameObject.GetComponentInParent<IClickable>();

                    if (c != null)
                    {
                        c.OnClick();
                        break;
                    }
                }
            }
        }
    }
}