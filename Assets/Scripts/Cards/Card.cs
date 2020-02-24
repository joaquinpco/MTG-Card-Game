using UnityEngine;

namespace AkeenDev
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public CardProperties[] properties;
        /*public string title;
        public Sprite art;
        public string detail;
        public string flavor;
        public string artist;*/
    }
}
