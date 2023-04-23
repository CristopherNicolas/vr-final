using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
[RequireComponent(typeof(BoxCollider))]

public class Checkpoint : MonoBehaviour
{
    private void Start()
    {
        GetComponent<BoxCollider>().isTrigger=true;    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "XR Origin")
        {
            Debug.Log("El jugador entro en un chckpoint, enemigosDetenidos");
            PonerEnemigosEnZonaInicial();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "XR Origin")
        {
            Debug.Log("El jugador salio del chckpoint, los enemigos se mueven despues de 10 segundos");
            ActivarMovimientoEnemigos();   
        }
    }
    void ActivarMovimientoEnemigos()
    {
        var enemigos = GameObject.FindObjectsOfType<Enemigo>().ToList();
        enemigos.ForEach(e => e.puedeMoverse=true);
        
    }
    void PonerEnemigosEnZonaInicial()
    {
        var enemigos = GameObject.FindObjectsOfType<Enemigo>().ToList();
        enemigos.ForEach(e => e.transform.root.transform.position = e.starPos);
    }
}
