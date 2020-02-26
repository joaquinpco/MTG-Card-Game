using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AkeenDev
{
    [CreateAssetMenu(menuName ="Variables/Card Variable")]
    public class CardVariable : ScriptableObject
    {
        public CardInstance value;

        public void Set(CardInstance v)
        {
            value = v;
        }
    }
}
