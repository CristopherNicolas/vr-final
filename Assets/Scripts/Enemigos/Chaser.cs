using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public class Chaser : Enemigo
{
    public int segundosDeMovimiento = 0,
        segundosDeMovimientoMaximo =10;
    public override void SerAlumbrado()
    {
        // no tiene efecto        
    }
    bool haComenzadoElCD = false;
    public override async void MoverEnemigo(Vector3 destino)
    { 
         //haComenzadoElCD = haComenzadoElCD ? true
            base.MoverEnemigo(destino);      
    }
    
}
