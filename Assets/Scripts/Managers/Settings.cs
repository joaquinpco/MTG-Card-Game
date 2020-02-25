using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AkeenDev
{
    public static class Settings
    {
        private static ResourcesManager _resourcesManager;

        public static ResourcesManager GetResourcesManager()
        {
            if (_resourcesManager == null)
                _resourcesManager = Resources.Load("ResourcesManager") as ResourcesManager;

            return _resourcesManager;
        }
    }
}