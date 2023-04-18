using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

//basilisco
public class Basilisco : Enemigo
{
    //tiempo de reaccion al entrar ala rango
    private async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name ==("XR Origin"))
        {
            //print(default)
        }
    }
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
    }
}
