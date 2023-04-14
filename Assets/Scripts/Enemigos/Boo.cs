using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public class Boo : Enemigo
{
    void Start()
    {
        velocidadDeMovimiento = 10;
    }
    public override void MoverEnemigo(Vector3 destino)
    {
        if (GameObject.FindObjectOfType<Linterna>()
            .enemigosDentroDeLaLuzLinterna.Exists(x => x == this.gameObject))
            puedeMoverse = false;
        else {puedeMoverse=true; }
        base.MoverEnemigo(destino);
    }
    public override void SerAlumbrado()
    {
        puedeMoverse = false;
        //animacion de detenerse
        //sonido detenerse?
    }
}
