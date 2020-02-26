using UnityEngine;
using System.Collections;
namespace AkeenDev.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/My Cards Down")]
    public class MyCardDown : GE_Logic
    {
        public override void OnClick(CardInstance cardInstance)
        {
            Debug.Log("This Card is mine but is on the table");
        }

        public override void OnHighlight(CardInstance cardInstance)
        {
            Debug.Log("This Card is mine but is on the table highlight");
        }
    }
}