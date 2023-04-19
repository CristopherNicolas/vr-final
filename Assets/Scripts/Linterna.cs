using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


[RequireComponent(typeof(Light))]
//[RequireComponent(typeof(SphereCollider))]
// se debe añadir a la linterna
public class Linterna : MonoBehaviour
{
    public List<GameObject> enemigosDentroDeLaLuzLinterna;
    Light luzLinterna;
    [SerializeField]float iluminacionMaxima = 60,iluminacionActual=41,bateriaActual=100, bateriaMax=100;
    private void Awake()
    {
        luzLinterna = GetComponent<Light>();
        luzLinterna.intensity = iluminacionActual;
        //16- 55    
        
    }

    [SerializeField] float velocidadDelay = 0.01f,areaMaxima;
    //[ContextMenu("Desvanecer ")]
    //public async Task Desvanecer()
    //{    // fade out
    //    for (; luzLinterna.areaSize.x > 0; luzLinterna.areaSize = new Vector2(luzLinterna.areaSize.y - 1, luzLinterna.areaSize.y - 1))
    //    {
    //        await Task.Delay(System.TimeSpan.FromMilliseconds(velocidadDelay));
    //        if (luzLinterna.areaSize == Vector2.zero)
    //        {
    //            print("area desvanecida");
    //        }
    //    }

    //    //esperar hasta que la bateria sea mayor que 0;
    //    while (bateriaActual == 0)
    //    {
    //        await Task.Delay(System.TimeSpan.FromSeconds(.1f));
    //        print("La bateria es 0, esperando por carga");
    //    }

    //    ////fade in        
    //    //for (; luzLinterna .areaSize.x < areaMaxima; luzLinterna.areaSize = new Vector2(luzLinterna.areaSize.y + 1, luzLinterna.areaSize.y + 1))
    //    //{
    //    //    await Task.Delay(System.TimeSpan.FromMilliseconds(velocidadDelay));
    //    //}
    //}


    // solo TOMAR la linterna


}
