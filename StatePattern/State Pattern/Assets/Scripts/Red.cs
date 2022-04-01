using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//2º Aqui implementa a parte concreta da interface com o contrato 
//onde aqui implementa a funcao da interface.
public class Red : MonoBehaviour, IState
{
    [SerializeField] SOIState SOIState;
   
    public void Color()
    {
        SOIState.state = this;
        SOIState.color = new Color(1, 0, 0, 1);
    }
}
