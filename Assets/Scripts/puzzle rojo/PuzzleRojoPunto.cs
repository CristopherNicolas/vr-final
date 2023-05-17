
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// se usa en el sistema de puzzle rojo
[RequireComponent(typeof(Light))]
public class PuzzleRojoPunto : MonoBehaviour
{
    Light l;
   private void Start()=> l = GetComponent<Light>();

    public void PrenderPunto()
    {
        l.DOColor(Color.red, 1);
        //sonido de prender luz puzzle rojo
    }
    public void ApagarPunto()
    {
        l.DOColor(Color.black, 1);
        // sonido de apagar luz puzzle rojo
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ColicionLinterna>() && !transform.parent.GetComponent<PuzzleRojo>().puntosRojosAlumbrados.Contains(this))
        {
            //comprobar si es la luz que sigue en el puzzle
            //si es la que continua, prender esta, si no ,resetear puzle
            PrenderPunto();
        }
    }

}
