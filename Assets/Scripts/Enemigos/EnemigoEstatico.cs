using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoEstatico : Enemigo
{
    public override void SerAlumbrado()
    {
        Debug.Log("Enemigo estatico alimbrado");
               
    }
    public override void MoverEnemigo(Vector3 destino)
    {
        return;
    }
    
}
