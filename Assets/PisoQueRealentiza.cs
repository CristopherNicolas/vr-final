using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]
public class PisoQueRealentiza : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Personaje>())
        {
            var personaje = other.GetComponent<Personaje>();
            personaje.velocidad /= 2;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Personaje>())
        {
            var personaje = other.GetComponent<Personaje>();
            personaje.velocidad *= 2; 
        }
        
    }
}
