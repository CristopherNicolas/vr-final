using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.AI;
/// <summary>
/// plantilla para la creacion de enemigos
/// </summary>
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
public abstract class Enemigo : MonoBehaviour
{
    Transform destino;
    public  AudioSource audioSource;
    public float velocidadDeMovimiento=10;
    public NavMeshAgent agent;
    public Vector3 starPos;
    public bool puedeMoverse = false;// debe comenzar en falsa hasta que el jugador salga de la zona segura se activa.
    [SerializeField] Animator animator;

    public abstract void SerAlumbrado();
    public void Awake() {
        CacheComponentes();
        agent.speed = velocidadDeMovimiento;
        starPos = transform.position;
    } 
    private void Update()
    {
        MoverEnemigo(destino.position);
    }
    protected virtual void CacheComponentes()
    {
        try
        {
         audioSource = GetComponent<AudioSource>();
         agent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
            destino = GameObject.Find("XR Origin").transform;
        }
        catch (System.Exception)
        {
            Debug.Log("error en referencias del enemigo");
            throw;
        }
    }
    /// <summary>
    /// Se actualiza en update de todos los enemigos
    /// </summary>
    /// <param name="destino"></param>
    public virtual void MoverEnemigo(Vector3 destino)
    {
        if (!puedeMoverse) { DetenerEnemigo();  return; } 
        agent.isStopped = false;
        agent.SetDestination(destino);
    }
    public virtual void DetenerEnemigo()
    {
        // aqui se pueden agregar audios al detenerse
        agent.isStopped = true;
    }
}
