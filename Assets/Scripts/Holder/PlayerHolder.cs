using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AkeenDev
{
    [CreateAssetMenu(menuName = "Holders/Player Holder")]
    public class PlayerHolder : ScriptableObject
    {
        public string[] startingCards;
        public SO.TransformVariable handGrid;
        public SO.TransformVariable downGrid;

        public GameElements.GE_Logic handLogic;
        public GameElements.GE_Logic downLogic;


        [System.NonSerialized]
        public List<CardInstance> handsCards = new List<CardInstance>();
        [System.NonSerialized]
        public List<CardInstance> cardsDown = new List<CardInstance>();
    }
}