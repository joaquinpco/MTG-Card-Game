using UnityEngine;
using System.Collections;

namespace AkeenDev.GameState
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Execute(float d);
    }
}