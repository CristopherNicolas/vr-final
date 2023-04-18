using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
//culebron
public class Chaser : Enemigo
{
    public int segundosDeMovimientoMaximo =10;
    public override void SerAlumbrado()
    {
        // no tiene efecto        
    }
    bool haComenzadoElCD = false;
    private void Start() => StartCoroutine(Timer());
    public override  void MoverEnemigo(Vector3 destino)
    { 
            base.MoverEnemigo(destino);      
    }
    IEnumerator Timer()
    {
            yield return new WaitUntil(() => puedeMoverse);
        while (true)
        {
            puedeMoverse = false;
            yield return new WaitForSecondsRealtime(segundosDeMovimientoMaximo);
            puedeMoverse = true;
            yield return new WaitForSecondsRealtime(segundosDeMovimientoMaximo);
        }
    }
}
