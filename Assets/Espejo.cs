using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espejo : MonoBehaviour
{
    float anguloDeInsidencia;
    public GameObject luz;
    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.forward,Color.red);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "colicionLinterna")
        {
            //reflejar luz dependiendo el angulod de incidencia
           anguloDeInsidencia= Quaternion.Angle(transform.rotation, other.transform.rotation);
            Debug.Log(anguloDeInsidencia);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "colicionLinterna")
        {
            //reflejar luz dependiendo el angulod de incidencia
            anguloDeInsidencia= Quaternion.Angle(transform.rotation, other.transform.rotation);
            Debug.Log(anguloDeInsidencia);
            luz.transform.rotation = Quaternion.Euler(0, anguloDeInsidencia, 0);
        }
    }
}
