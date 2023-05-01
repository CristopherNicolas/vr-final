using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(AudioSource))]
public class Personaje : MonoBehaviour
{
    public float velocidad;
    PlayerInput xrInput;
    public AudioSource audioSourceJugador;
    bool estaEnZonaSegura = true;
    public void Start()
    {
        xrInput = GetComponent<PlayerInput>();
        audioSourceJugador = GetComponent<AudioSource>();
    }
    // agacharse
    private void Update()
    {
        if (xrInput.actions["Activate"].IsPressed())
        {
            Debug.Log("xr input presionado");
        }
    }
    public void Agacharse()
    {
        // el input debe mantenerse para mantenerse agachado
        AudioSystem.instance.PonerSonido("agacharse", 5);
        AudioSystem.instance.PonerSonido("agacharse", 5,2.1f,GameObject.Find("Boo").GetComponent<AudioSource>());
    }
}
