using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AkeenDev
{
    public class CurrentSelected : MonoBehaviour
    {
        public CardVariable currentCard;
        public CardViz cardViz;
        Transform mtransform;

        public void LoadCard()
        {
            if(currentCard.value != null)
            {
                currentCard.value.gameObject.SetActive(false);
                cardViz.LoadCard(currentCard.value.viz.card);
                cardViz.gameObject.SetActive(true);
            }
        }

        public void closeCard()
        {
            cardViz.gameObject.SetActive(false);
        }

        private void Start()
        {
            mtransform = this.transform;
            closeCard();
        }
        void Update()
        {
            mtransform.position = Input.mousePosition;
        }
    }
}