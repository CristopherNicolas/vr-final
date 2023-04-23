using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Personaje : MonoBehaviour
{
    public float velocidad;
    public AudioSource audioSourceJugador;
    bool estaEnZonaSegura = true;
    public void Start()
    {
        audioSourceJugador = GetComponent<AudioSource>();
    }
}
