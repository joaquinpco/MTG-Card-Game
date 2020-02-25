using UnityEngine;
using System.Collections;
using AkeenDev.GameState;

namespace AkeenDev
{
    public class GameManager : MonoBehaviour
    {
        public State currentState;
        // Update is called once per frame
        void Update()
        {
            currentState.Tick(Time.deltaTime);
        }
    }
}