using UnityEngine;
using System.Collections;

namespace AkeenDev.GameElements
{
    public class Area : MonoBehaviour
    {
        public AreaLogic areaLogic;
        public void OnDrop()
        {
            areaLogic.Execute();
        }
    }
}