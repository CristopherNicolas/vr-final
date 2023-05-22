using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;
public class PuzzleRojo : MonoBehaviour
{
    // todo se produce en base que la luz activada sea roja.
    //dada una cierta cantidad de puntos, pasar por una ruta especifica, en caso de iluminar otro punto no prendido
    // desactivar todos los enemigos de la escena.
    public List<PuzzleRojoPunto> puntosPuzle,puntosRojosAlumbrados;
    public GameObject prefabPuzlePunto;
    public virtual void Efecto()
    {
        print("efecto");
        transform.DOMoveY(2,1.5f);
    }
    public void ResetearPuzzle()
    {
        puntosRojosAlumbrados.ForEach(p => p.ApagarPunto());
        puntosRojosAlumbrados.Clear();
    }
    public bool Comprobar()
    {
        if(puntosRojosAlumbrados.Count != puntosPuzle.Count) { Debug.Log("no hay suficientes puntos alumbrados"); return false;}
        bool []  arr = new bool[puntosPuzle.Count]; 
        for (int i = 0; i < puntosRojosAlumbrados.Count; i++)
    arr[i] = puntosRojosAlumbrados[i] == puntosPuzle[i] ? true : false;
        if (arr.All(x => x == true)) return true; else return false;            
    }

    [ContextMenu("generar puntos")]
    public void GenerarPuntosEnPrefab()
    {
        for (int i = 0; i < 3; i++)
        {
            puntosPuzle.Add(Instantiate(prefabPuzlePunto, transform).GetComponent<PuzzleRojoPunto>());
                
        }
    }
}
    
