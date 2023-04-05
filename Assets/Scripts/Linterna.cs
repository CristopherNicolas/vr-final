using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


[RequireComponent(typeof(Light))]
[RequireComponent(typeof(SphereCollider))]
// se debe añadir a la linterna
public class Linterna : MonoBehaviour
{
    Light luzLinterna;
    [
        SerializeField]float iluminacionMaxima = 60,iluminacionActual=41,coeficienteDeDesvanecer=53;
    private void Awake()
    {
        luzLinterna = GetComponent<Light>();
        luzLinterna.intensity = iluminacionActual;
        //16- 55    
        
    }
    [ContextMenu("Desvanecer Luz")]
    public async void DesvanecerLuz()
    {
        for (int i = 0; i < coeficienteDeDesvanecer; i++)
        {
            luzLinterna.intensity--;
            await Task.Delay(10);
        }
        for (float i = luzLinterna.intensity; i < iluminacionMaxima; i++)
        {
            luzLinterna.intensity++;
            await Task.Delay(10);
        }
    }
 // solo TOMAR la linterna

    
}
