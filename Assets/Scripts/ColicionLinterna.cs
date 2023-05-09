using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Linq;
public class ColicionLinterna : MonoBehaviour
{
    Linterna linterna;
    private void Awake()
    {
        linterna = transform.parent.GetComponent<Linterna>();
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Enemigo colicionado");
            linterna.enemigosDentroDeLaLuzLinterna.Add(other.gameObject);
        }
        else if(other.gameObject.GetComponent<PuzzleRojoPunto>())
        {
            var puzzle = other.transform.parent.GetComponent<PuzzleRojo>();
            other.GetComponent<PuzzleRojoPunto>().PrenderPunto();
        }
    }
    public virtual void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemigo") && linterna.enemigosDentroDeLaLuzLinterna
            .Exists(x => x == other.gameObject))
        {
            Debug.Log("Enemigo sale de la luz");
            linterna.enemigosDentroDeLaLuzLinterna.Remove(other.gameObject);
        }
    }
}
