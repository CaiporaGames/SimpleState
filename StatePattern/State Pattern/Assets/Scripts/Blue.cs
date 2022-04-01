using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue : MonoBehaviour, IState
{
    [SerializeField] SOIState SOIState;   

    public void Color()
    {
        SOIState.state = this;
        SOIState.color = new Color(0, 0, 1, 1);       
    }   
}
