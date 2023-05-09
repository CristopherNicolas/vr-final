using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRojo : MonoBehaviour
{
    // todo se produce en base que la luz activada sea roja.
    //dada una cierta cantidad de puntos, pasar por una ruta especifica, en caso de iluminar otro punto no prendido
    // desactivar todos los enemigos de la escena.
    public List<PuzzleRojoPunto> puntosPuzle;
    public GameObject prefabPuzlePunto;
    

    public virtual void Efecto()
    {
        print("efecto");
    }
    public void ResetearPuzzle()
    {

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
    
