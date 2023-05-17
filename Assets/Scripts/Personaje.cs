using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(PlayerInput))]
public class Personaje : MonoBehaviour
{
    public float velocidad;
    PlayerInput xrInput;
    public AudioSource audioSourceJugador;
    public List<Bengala> bengalas;
    bool estaEnZonaSegura = true,estaAgachado=false;
    Linterna linterna;
    Vector3 offset;

    public void Start()
    {
        linterna = GameObject.FindObjectOfType<Linterna>();
        xrInput = GetComponent<PlayerInput>();
        audioSourceJugador = GetComponent<AudioSource>();
        offset = transform.GetChild(0).transform.position;
    }
    // agacharse
    private void Update()
    {
        if (xrInput.actions["Activate"].IsPressed()||Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("xr input derecho presionado");


            TIPOLINTERNA tIPOLINTERNA = linterna.tipolINTERNA;
            switch (tIPOLINTERNA)
            {
                case TIPOLINTERNA.TipoLinternaRoja:
                    linterna.CambiarTipoDeLinterna(TIPOLINTERNA.TipoLinternaBlanca);
                    break;
                case TIPOLINTERNA.TipoLinternaBlanca:
                    linterna.CambiarTipoDeLinterna(TIPOLINTERNA.TipoLinternaAzul);
                    break;
                case TIPOLINTERNA.TipoLinternaAzul:
                    linterna.CambiarTipoDeLinterna(TIPOLINTERNA.TipoLinternaRoja);
                    break;
                default:
                    break;
            }


        }
        if (xrInput.actions["Agacharse"].IsPressed())
        {
            print("agachado");
            if (estaAgachado)
            {
              transform.GetChild(0).transform.position = offset;
                estaAgachado = false;
            }
            else
            {
                transform.GetChild(0).transform.position = offset/2;
                estaAgachado = true;
            }
        }
    }
    public void Agacharse()
    {
        // el input debe mantenerse para mantenerse agachado
        AudioSystem.instance.PonerSonido("agacharse", 5);
        AudioSystem.instance.PonerSonido("agacharse", 5,2.1f,GameObject.Find("Boo").GetComponent<AudioSource>());
    }
}
