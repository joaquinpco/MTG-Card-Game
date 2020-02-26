using UnityEngine;
using System.Collections;

namespace AkeenDev
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public CardViz viz;
        public AkeenDev.GameElements.GE_Logic currentLogic;

        void Start()
        {
            viz = GetComponent<CardViz>();
        }

        public void OnClick()
        {
            Debug.Log("Clicked ");
            if(currentLogic != null)
                currentLogic.OnClick(this);
        }

        public void OnHighlight()
        {
            if (currentLogic != null)
                currentLogic.OnHighlight(this);
        }
    }
}