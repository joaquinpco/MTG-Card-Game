using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace AkeenDev
{
    public class CardViz : MonoBehaviour
    {
        //Instance of One Card Model
        public Card card;
        public CardVizProperties[] properties;
        public GameObject statsHolder;

        public void LoadCard(Card  c)
        {
            if (c != null)
            {
                card = c;
                card.cardType.OnSetType(this);
                
                for(int i = 0; i < c.properties.Length; i++)
                {
                    CardProperties cp = c.properties[i];

                    CardVizProperties p = GetProperty(cp.element);

                    if(cp.element is ElementInt)
                    {
                        if (cp != null) { }
                            //p.text.text = cp.intValue.ToString();
                    }
                    else if(cp.element is ElementText)
                    {
                        p.text.text = cp.stringValue;
                    }
                    else 
                        if(cp.element is ElementImage)
                        {
                            p.img.sprite = cp.sprite;
                        }
                }
            }
        }

        public CardVizProperties GetProperty(Element e)
        {
            CardVizProperties cardVizProperties = null;
            bool finded = false;

            for(int i = 0; i < properties.Length && !finded; i++)
            {
                if(properties[i].element == e)
                {
                    cardVizProperties = properties[i];
                    finded = true;
                }
            }

            return cardVizProperties;
        }

        // Use this for initialization
        void Start()
        {
            LoadCard(card);
        }
    }
}