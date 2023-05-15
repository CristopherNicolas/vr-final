using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

// se debe añadir a la linterna
public class Linterna : MonoBehaviour
{
    public TIPOLINTERNA tipolINTERNA;
    public List<GameObject> enemigosDentroDeLaLuzLinterna;
    Light luzLinterna;
    [SerializeField]float iluminacionMaxima = 60,iluminacionActual=41,bateriaActual=100, bateriaMax=100;
    private void Awake()
    {
        luzLinterna = transform.GetChild(0).GetComponent<Light>();
        luzLinterna.intensity = iluminacionActual;
        //16- 55       
    }
    [SerializeField] float velocidadDelay = 0.01f,areaMaxima;

    private void OnTriggerEnter(Collider other)
    {
        //poner sonido de tomar linterna aqui
        if (other.gameObject.name == "Direct Interactor")
        {
            print("linterna colicionada con brazo,añadida como parent");
            transform.parent = other.gameObject.transform;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<BoxCollider>().isTrigger = true;
        }
    }
    void CambiarColorLuz(Color c) => luzLinterna.color = c;
    [ContextMenu("Cambiar de linterna segun el enum de la clase linterna")]
    public void CambiarTipoDeLinterna(TIPOLINTERNA _tIPOLINTERNA)
    {
        tipolINTERNA = _tIPOLINTERNA;
        switch (tipolINTERNA)
        {
            case TIPOLINTERNA.TipoLinternaRoja:
                CambiarColorLuz(Color.red);
                //cambiar estructura de colicionLinterna
                transform.GetChild(1).transform.localScale
                    = new Vector3(1.1558969f, 1.1091336f, 28.1805058f);
                transform.GetChild(1).transform.position = new Vector3(-0.5f, -29, 1);
                // cambiar forma de luz de linterna
                luzLinterna.spotAngle = 7;
                break;



            case TIPOLINTERNA.TipoLinternaBlanca:
                CambiarColorLuz(Color.white);
                transform.GetChild(1).transform.localScale
                    = new Vector3(12.9943323f, 11.730567f, 28.1805058f);
                transform.GetChild(1).transform.position = new Vector3(-0.5f, -29f, 1f);
                luzLinterna.spotAngle = 55;
                break;
               default:
                break;
        }
                // agregar sonido de cambio de luz aqui
    }
}
public enum TIPOLINTERNA
{
    TipoLinternaRoja, TipoLinternaBlanca
}
