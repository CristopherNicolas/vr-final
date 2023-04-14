using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// plantilla para la creacion de enemigos
/// </summary>
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(NavMeshAgent))]
public abstract class Enemigo : MonoBehaviour
{
    [SerializeField] Vector3 destino;
    [SerializeField] AudioSource audioSource;
    public float velocidadDeMovimiento=10;
    public NavMeshAgent agent;
    public bool puedeMoverse = false;// debe comenzar en falsa hasta que el jugador salga de la zona segura se activa.
    [SerializeField] Animator animator;

    public abstract void SerAlumbrado();
    public void Awake() {
        CacheComponentes();
        agent.speed = velocidadDeMovimiento;
    } 
    private void Update()
    {
        MoverEnemigo(destino);
    }
    protected virtual void CacheComponentes()
    {
        try
        {
         audioSource = GetComponent<AudioSource>();
         agent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
            destino = GameObject.Find("XR Origin").transform.position;
        }
        catch (System.Exception)
        {
            Debug.Log("error en referencias del enemigo");
            throw;
        }
    }
    public virtual void MoverEnemigo(Vector3 destino)
    {
        if (!puedeMoverse) { DetenerEnemigo();  return; } 
        agent.isStopped = false;
        agent.SetDestination(destino);
    }
    public virtual void DetenerEnemigo()
    {
        puedeMoverse =false;
        agent.isStopped = true;
    }
}
