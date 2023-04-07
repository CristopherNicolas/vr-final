using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;
using System.Threading.Tasks;
[  RequireComponent(typeof(AudioSource)) ]
public class AudioSystem : MonoBehaviour
{
    public static AudioSystem instance;
    public AudioSource globalAudioSource;
     public List<AudioClip> audios;
    public void Awake()
    {
        if(instance == null) {
        instance = this;
        DontDestroyOnLoad(gameObject);
        } else Destroy(gameObject); 
       globalAudioSource = GetComponent< AudioSource >  ();
    }

    /// <summary>
    /// Escribe el nombre del archivo de audio y luego el delay
    /// </summary>
    /// <param name="nombreAudio"></param>
    /// <param name="delay"></param>
    public async void PonerSonido(string nombreAudio,float delay=0)
    {
    AudioClip clip = audios.Where( c => c.name == nombreAudio).First();
     if(clip == null ) 
     {print("no hay audio con ese nombre"); return;}
    await Task.Delay(TimeSpan.FromSeconds(delay));
      globalAudioSource.PlayOneShot(clip);
    }
    
    /// <summary>
    /// Escribe el sonido del audio a poner 
    /// </summary>
    /// <param name="numero"></param>
    public void CambiarVolumenGlobal(float numero)
    {
         var fuentes = GameObject.FindObjectsOfType<AudioSource>();
          foreach (var f in fuentes)
          {
              f.volume -=  numero;
          }
          
    }

    // ejemplo: en cualquier parte del codigo  poner : AudioSystem.instance.PonerSonido("pasos");
}
