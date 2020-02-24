using UnityEngine;

namespace AkeenDev
{
    [CreateAssetMenu(menuName = "Card")]
    public class Card : ScriptableObject
    {
        public CardType cardType;
        public CardProperties[] properties;
    }
}
