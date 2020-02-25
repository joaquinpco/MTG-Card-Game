using UnityEngine;
using System.Collections;

public abstract class Action : ScriptableObject
{
    public abstract void Execute(float d);
}
