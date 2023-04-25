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
    // agacharse
    public void Agacharse()
    {
        // el input debe mantenerse para mantenerse agachado
        AudioSystem.instance.PonerSonido("agacharse", 5);
        AudioSystem.instance.PonerSonido("agacharse", 5,2.1f,GameObject.Find("Boo").GetComponent<AudioSource>());
    }
}
