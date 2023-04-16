
using System.Runtime.InteropServices;
using System.Diagnostics.Contracts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstatico : Enemigo
{
    public bool puedeVigilar = false;
    public override void SerAlumbrado()
    {
        Debug.Log("Enemigo estatico alimbrado");
               
    }
    public override void MoverEnemigo(Vector3 destino)
    {
        return;
    }
    IEnumerator  Start()
    {
        while(true)
        {
            while(puedeVigilar)
            {
                yield return new WaitForSeconds(0.01f);
                //rotar segun la rotacion actual   
                transform.Rotate(new Vector3(0, 0, 0));
            }
            yield return new WaitForEndOfFrame();  
        }
    }
}
