using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour, IState
{
    [SerializeField] SOIState SOIState;

    public void Color()
    {
        SOIState.state = this;
        SOIState.color = new Color(1, 1, 0, 1);
    }
}
