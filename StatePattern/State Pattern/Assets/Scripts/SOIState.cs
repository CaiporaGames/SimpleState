using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "State", menuName = "Scriptable Objects / State")]
public class SOIState : ScriptableObject
{
    public IState state;
    [HideInInspector]
    public Color color;
}
