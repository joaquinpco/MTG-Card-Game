using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace AkeenDev
{
    public static class Settings
    {
        private static ResourcesManager _resourcesManager;

        public static GameManager gameManager;

        public static ResourcesManager GetResourcesManager()
        {
            if (_resourcesManager == null)
                _resourcesManager = Resources.Load("ResourcesManager") as ResourcesManager;

            return _resourcesManager;
        }

        public static List<RaycastResult> GetUIObjs()
        {
            PointerEventData pointerEventData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, results);
            return results;
        }
    }
}