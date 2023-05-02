using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bengala : MonoBehaviour
{
    public bool estaTomada;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Direct Interactor")
        {
            estaTomada = true;
            var player = GameObject.FindObjectOfType<Personaje>();
            player.bengalas.Add(this);
            other.transform.SetParent(other.transform);
        }
    }
}
