using UnityEngine;
using System.Collections;
using AkeenDev.GameState;

namespace AkeenDev
{
    public class GameManager : MonoBehaviour
    {
        public PlayerHolder currentPlayer;
        public State currentState;
        public GameObject cardPrefab;
        // Update is called once per frame
        void Update()
        {
            currentState.Tick(Time.deltaTime);
        }

        void creatingStartingCards()
        {
            ResourcesManager rm = Settings.GetResourcesManager();
            
            for(int i = 0; i < currentPlayer.startingCards.Length; i++)
            {
                GameObject go = Instantiate(cardPrefab) as GameObject;
                CardViz v = go.GetComponent<CardViz>();
                v.LoadCard(rm.GetCardInstance(currentPlayer.startingCards[i]));
                CardInstance inst = go.GetComponent<CardInstance>();
                inst.currentLogic = currentPlayer.handLogic;
                Settings.SetParentForCard(go.transform, currentPlayer.handGrid.value);
            }
        }

        private void Start()
        {
            Settings.gameManager = this;
            creatingStartingCards();
        }

        public void SetState(State state)
        {
            currentState = state;
        }
    }
}