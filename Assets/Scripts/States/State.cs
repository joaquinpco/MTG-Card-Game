using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AkeenDev.GameState
{
    [CreateAssetMenu(menuName = "State")]
    public class State : ScriptableObject
    {
        public Action[] actions;
        public void Tick(float d)
        {
            for(int i = 0; i < actions.Length; i++)
            {
                actions[i].Execute(d);
            }
        }
    }
}