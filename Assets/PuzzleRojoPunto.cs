
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// se usa en el sistema de puzzle rojo
[RequireComponent(typeof(Light))]
public class PuzzleRojoPunto : MonoBehaviour
{
    Light l;
    private void Start()
    {
        l = GetComponent<Light>();
    }
    public void   PrenderPunto()
    {
        l.DOColor(Color.red, 1);
    }
    public void     ApagarPunto()
    {

        l.DOColor(Color.black, 1);
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ColicionLinterna>())
        {
            //comprobar si es la luz que sigue en el puzzle
            //si es la que continua, prender esta, so no resetear puzle
        }
    }

}
