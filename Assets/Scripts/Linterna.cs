using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;


//[RequireComponent(typeof(Light))]
//[RequireComponent(typeof(SphereCollider))]
// se debe añadir a la linterna
public class Linterna : MonoBehaviour
{
    public List<GameObject> enemigosDentroDeLaLuzLinterna;
    Light luzLinterna;
    [SerializeField]float iluminacionMaxima = 60,iluminacionActual=41,bateriaActual=100, bateriaMax=100;
    private void Awake()
    {
        luzLinterna = GetComponent<Light>();
        luzLinterna.intensity = iluminacionActual;
        //16- 55    
        
    }

    [SerializeField] float velocidadDelay = 0.01f,areaMaxima;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Direct Interactor")
        {
            print("flag");
            transform.parent = other.gameObject.transform;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    /// <summary>
    /// se usa con las piedras
    /// </summary>
    /// <param name="c"></param>
    void CambiarColorLuz(Color c) => luzLinterna.color = c;

}
