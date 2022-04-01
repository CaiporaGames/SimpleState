using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aqui é um objeto dentro do jogo que vamos modificar o estado baseado em alguma acao do jogo

public class Base : MonoBehaviour
{
    [SerializeField] SOIState SOIState;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<IState>() != null)
        {
            SOIState.state = other.gameObject.GetComponent<IState>();
            SOIState.state.Color();
            GetComponent<Renderer>().material.SetColor("_BaseColor", SOIState.color);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<IState>() != null)
        {
            GetComponent<Renderer>().material.SetColor("_BaseColor", Color.white);
        }
    }
     
}
