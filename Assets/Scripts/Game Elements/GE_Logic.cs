using UnityEngine;
using System.Collections;

namespace AkeenDev.GameElements
{
    public abstract class GE_Logic : ScriptableObject
    {
        public abstract void OnClick(CardInstance cardInstance);
        public abstract void OnHighlight(CardInstance cardInstance);
    }
}