using UnityEngine;

namespace AkeenDev
{
    [CreateAssetMenu(menuName = "Cards")]
    public class Card : ScriptableObject
    {
        public string title;
        public Sprite art;
        public string detail;
        public string flavor;
        public string artist;
    }
}
