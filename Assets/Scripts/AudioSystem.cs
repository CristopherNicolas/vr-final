using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Collections;
using UnityEngine.Audio;
using System.Threading.Tasks;
[RequireComponent(typeof(AudioSource))]
public class AudioSystem : MonoBehaviour
{
    public static AudioSystem instance;
    public AudioSource globalAudioSource, bgAudiosurce;
    public List<AudioClip> audios;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
        globalAudioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Escribe el nombre del archivo de audio y luego el delay, trabajar valores del pitch entre 0 a 10
    /// </summary>
    /// <param name="nombreAudio"></param>
    /// <param name="delay"></param>
    public async void PonerSonido(string nombreAudio, float pitch, float delay = 0,  AudioSource source = null)
    {
        if (source == null) globalAudioSource.pitch = pitch; else source.pitch = pitch;
        AudioClip clip = audios.Where(c => c.name == nombreAudio).First();
        if (clip == null)
        { print("no hay audio con ese nombre"); return; }
        await Task.Delay(TimeSpan.FromSeconds(delay));
        if (source == null)
            globalAudioSource.PlayOneShot(clip);
        else source.PlayOneShot(clip);
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
            f.volume -= numero;
        }

    }

    // ejemplo: en cualquier parte del codigo  poner : AudioSystem.instance.PonerSonido("pasos");
    //AudioSystem.instance.PonerSonido("agacharse", 5);
        //(AudioSystem.instance.PonerSonido("agacharse", 5,2.1f,GameObject.Find("Boo").GetComponent<AudioSource>());
}
