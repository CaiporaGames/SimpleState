using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White : MonoBehaviour, IState
{
    [SerializeField] SOIState SOIState;

    public void Start()
    {
        SOIState.state = this;
    }

    public void Color()
    {
        SOIState.state = this;
        SOIState.color = new Color(1, 1, 1, 1);
    }
}
